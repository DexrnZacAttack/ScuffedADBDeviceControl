using ADBScuffedMirroring.ADB;
using AdvancedSharpAdbClient.DeviceCommands;

namespace ADBScuffedMirroring
{
    public partial class InputTextForm : Form
    {
        ADBInstance inst;
        public InputTextForm(ADBInstance inst)
        {
            this.inst = inst;
            InitializeComponent();
            inputTextBox.Focus();
        }

        private async void inputBtn_Click(object sender, EventArgs e)
        {
            inputTextBox.Enabled = false;
            inputBtn.Enabled = false;
            // jank, should probably do this a better way.
            await inst.client.SendTextAsync(inst.deviceData, inputTextBox.Text
                .Replace("%", @"\%")
                .Replace(" ", "%s")
                .Replace("\"", @"\""")
                .Replace("'", @"\'")
                .Replace("(", @"\(")
                .Replace(")", @"\)")
                .Replace("&", @"\&")
                .Replace("<", @"\<")
                .Replace(">", @"\>")
                .Replace(";", @"\;")
                .Replace("*", @"\*")
                .Replace("|", @"\|")
                .Replace("~", @"\~")
                .Replace("¬", @"\¬")
                .Replace("`", @"\`"));
            this.Close();
        }
    }
}
