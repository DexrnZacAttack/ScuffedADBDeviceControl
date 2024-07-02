using ADBScuffedMirroring.ADB;
using AdvancedSharpAdbClient;
using AdvancedSharpAdbClient.DeviceCommands;
using AdvancedSharpAdbClient.Exceptions;
using AdvancedSharpAdbClient.Receivers;
using System.Diagnostics;
using System.Reflection;
using static ADBScuffedMirroring.ADB.DeviceHandler;
using static ADBScuffedMirroring.ADB.Keycodes;
namespace ADBScuffedMirroring
{
    public partial class deviceForm : Form
    {
        ADBInstance inst = new(new AdbClient());
        private bool curDragging = false;
        private bool isMouseClicked = false;
        private Point startPoint;
        private Point endPoint;
        ConsoleOutputReceiver receiver = new ConsoleOutputReceiver();
        private Stopwatch dragTime = new Stopwatch();

        public deviceForm()
        {
            // Dexrn: Welcome to scuffed code... I am by no means a good, or even okay C# coder (atleast that's what people tell me).
            InitializeComponent();
            init();
        }

        private void init()
        {
            // if device "isEmpty" then set to null.
            if (inst.deviceData.IsEmpty)
            {
                inst = null;
            }
            string model = inst.deviceData.Model ?? "Unknown/Disconnected";
            Text = $"SADC: {model}";
        }

        private void mouseDown(object sender, MouseEventArgs e)
        {
            dragTime.Stop();
            Debug.WriteLine(e.Button);
            if (e.Button == MouseButtons.Left)
            {
                isMouseClicked = true;
                startPoint = new Point(e.X, e.Y);
                dragTime.Start();
            }
        }
        private async void mouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseClicked = false;
                curDragging = false;
                endPoint = new Point(e.X, e.Y);
                dragTime.Stop();

                double timeDragging = dragTime.Elapsed.TotalMilliseconds;

                if (timeDragging > 2000)
                {
                    Debug.WriteLine($"Swipe from {startPoint} to {endPoint} in {timeDragging}ms");
                    await inst.client.SwipeAsync(inst.deviceData, startPoint, endPoint, (long)timeDragging);
                }
            }
        }

        private async void timerTick(object sender, EventArgs e)
        {
            if (screenBox != null && !inst.deviceData.IsEmpty)
            {
                try
                {
                    // Dexrn: This is done as the original purpose of this was to allow for screen mirroring of my ANS F30, which does not have a working encoder.
                    // This should not be done in normal circumstances but unfortunately I want compatibility over functionality.
                    screenBox.Image = await GrabFrameBuffer(inst.client, inst.deviceData);
                    if (screenBox.Image != null)
                    {
                        connectBtn.Visible = false;
                        int? width = screenBox.Image.Size.Width;
                        int? height = screenBox.Image.Size.Height;
                        screenBox.Size = new Size((width ?? 240) + 8, (height ?? 320) + 28);
                        tabs.Size = new Size((width ?? 240) + 8, (height ?? 320) + 28);
                        ClientSize = new Size((width ?? 240) + 8, (height ?? 320) + 28 + 20);
                    }
                    else
                    {
                        connectBtn.Visible = true;
                    }
                }
                catch (Exception ex)
                {
                    tabs.Size = new Size(240 + 8, 320 + 28);
                    ClientSize = new Size(240 + 8, 320 + 28);
                }
            }
        }

        private async void clickScreen(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;
            Debug.WriteLine("Click at " + coordinates);
            await inst.client.ClickAsync(inst.deviceData, coordinates);
        }

        private async void keyPress(object sender, KeyEventArgs e)
        {
            if (tabs.SelectedIndex == 0)
            {
                Debug.WriteLine(((Keys)e.KeyValue).ToString());
                Debug.WriteLine(GetKeycode((Keys)e.KeyValue).ToString());
                await inst.client.SendKeyEventAsync(inst.deviceData, GetKeycode((Keys)e.KeyValue).ToString());
            }
        }

        private void SetMPFBtn(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = Int32.Parse(textBox1.Text);
            }
            catch
            {
                Debug.WriteLine($"Invalid '{textBox1.Text}'");
            }
        }

        private async void InstallAPKBtn(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "APK files (*.apk)|*.apk";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                using (FileStream stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    await inst.client.InstallAsync(inst.deviceData, stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error installing APK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void powerBtn_ClickAsync(object sender, EventArgs e)
        {
            switch (powerDrpDwn.SelectedItem.ToString())
            {
                // ew
                case "Reboot":
                    await inst.client.RebootAsync("", inst.deviceData);
                    break;
                case "Reboot (Recovery)":
                    await inst.client.RebootAsync("recovery", inst.deviceData);
                    break;
                case "Reboot (Bootloader)":
                    await inst.client.RebootAsync("bootloader", inst.deviceData);
                    break;
                case "Reboot (Sideload)":
                    await inst.client.RebootAsync("sideload", inst.deviceData);
                    break;
                case "Shutdown":
                    await inst.client.ExecuteShellCommandAsync(inst.deviceData, "reboot -P");
                    break;
                default:
                    MessageBox.Show("No power mode selected!", "No power mode selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void connectBtn_Click(object sender, EventArgs e)
        {
            init();
        }

        private async void consoleInput_KeyDown(object sender, KeyEventArgs e)
        {
            if ((Keys)e.KeyValue == Keys.Enter)
            {
                string command = consoleInput.Text;
                consoleInput.Text = "";
                consoleOutput.Text += $"> {command}\n";
                try
                {
                    ConsoleOutputReceiver receiver = new ConsoleOutputReceiver();
                    await inst.client.ExecuteShellCommandAsync(inst.deviceData, command, receiver);

                    if (receiver.ToString() != "")
                    {
                        consoleOutput.Text += $"{receiver}\n";
                    }
                }
                catch (ShellCommandUnresponsiveException ex)
                {
                    consoleOutput.Text += $"{ex.InnerException.Message}\n";
                }
            }
        }

        private async void rootBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await inst.client.RootAsync(inst.deviceData);
            }
            catch (AdbException ex)
            {
                MessageBox.Show($"Device returned error: {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deviceForm_Load(object sender, EventArgs e)
        {

        }

        private async void backBtn_Click(object sender, EventArgs e)
        {
            await inst.client.SendKeyEventAsync(inst.deviceData, AndroidKeys.KEYCODE_BACK.ToString());
        }

        private async void homeBtn_Click(object sender, EventArgs e)
        {
            await inst.client.SendKeyEventAsync(inst.deviceData, AndroidKeys.KEYCODE_HOME.ToString());
        }

        private async void tasksBtn_Click(object sender, EventArgs e)
        {
            await inst.client.SendKeyEventAsync(inst.deviceData, AndroidKeys.KEYCODE_APP_SWITCH.ToString());
        }

        private async void volumeUpBtn_Click(object sender, EventArgs e)
        {
            await inst.client.SendKeyEventAsync(inst.deviceData, AndroidKeys.KEYCODE_VOLUME_UP.ToString());
        }

        private async void volumeDownBtn_Click(object sender, EventArgs e)
        {
            await inst.client.SendKeyEventAsync(inst.deviceData, AndroidKeys.KEYCODE_VOLUME_DOWN.ToString());
        }

        private async void volumeMuteBtn_Click(object sender, EventArgs e)
        {
            await inst.client.SendKeyEventAsync(inst.deviceData, AndroidKeys.KEYCODE_VOLUME_MUTE.ToString());
        }

        private void inputStartBtn_Click(object sender, EventArgs e)
        {
            new InputTextForm(inst).ShowDialog();
        }
    }
}
