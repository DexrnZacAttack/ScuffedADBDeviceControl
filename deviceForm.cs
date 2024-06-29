using ADBScuffedMirroring.ADB;
using AdvancedSharpAdbClient;
using AdvancedSharpAdbClient.DeviceCommands;
using System.Diagnostics;
using static ADBScuffedMirroring.ADB.DeviceHandler;
using static ADBScuffedMirroring.ADB.Keycodes;
namespace ADBScuffedMirroring
{
    public partial class deviceForm : Form
    {
        ADBInstance inst = new(new AdbClient());

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
                        ClientSize = new Size((width ?? 240) + 8, (height ?? 320) + 28);
                    } else
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
            await inst.client.ClickAsync(inst.deviceData, coordinates);
        }

        private async void keyPress(object sender, KeyEventArgs e)
        {
            if (tabs.SelectedIndex == 0)
            {
                Debug.WriteLine(getKeycode((Keys)e.KeyValue).ToString());
                await inst.client.SendKeyEventAsync(inst.deviceData, getKeycode((Keys)e.KeyValue).ToString());
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
    }
}
