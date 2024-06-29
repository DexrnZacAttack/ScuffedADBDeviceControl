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
            Text = $"SASM: {inst.deviceData.Model}";
        }

        private async void timerTick(object sender, EventArgs e)
        {
            if (screenBox != null)
            {
                screenBox.Image = await GrabFrameBuffer(inst.client, inst.deviceData);
                tabs.Size = new Size(screenBox.Image.Size.Width + 8, screenBox.Image.Size.Height + 28);
                ClientSize = new Size(screenBox.Image.Size.Width + 8, screenBox.Image.Size.Height + 28);
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
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error installing APK", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
