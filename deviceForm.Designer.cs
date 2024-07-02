namespace ADBScuffedMirroring
{
    partial class deviceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolStripDropDownButton backBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deviceForm));
            ToolStripDropDownButton homeBtn;
            ToolStripDropDownButton tasksBtn;
            ToolStripDropDownButton inputStartBtn;
            screenBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            testToolStripMenuItem = new ToolStripMenuItem();
            tabs = new TabControl();
            screenPage = new TabPage();
            connectBtn = new Button();
            consoleTab = new TabPage();
            consoleInput = new TextBox();
            consoleOutput = new RichTextBox();
            deviceControl = new TabPage();
            rootBtn = new Button();
            powerBtn = new Button();
            powerText = new Label();
            powerDrpDwn = new ComboBox();
            button2 = new Button();
            settingsPage = new TabPage();
            label1 = new Label();
            button1 = new Button();
            FPSLabel = new Label();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            volDropDown = new ToolStripDropDownButton();
            volumeUpBtn = new ToolStripMenuItem();
            volumeDownBtn = new ToolStripMenuItem();
            volumeMuteBtn = new ToolStripMenuItem();
            backBtn = new ToolStripDropDownButton();
            homeBtn = new ToolStripDropDownButton();
            tasksBtn = new ToolStripDropDownButton();
            inputStartBtn = new ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)screenBox).BeginInit();
            contextMenuStrip1.SuspendLayout();
            tabs.SuspendLayout();
            screenPage.SuspendLayout();
            consoleTab.SuspendLayout();
            deviceControl.SuspendLayout();
            settingsPage.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // backBtn
            // 
            backBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            backBtn.Image = (Image)resources.GetObject("backBtn.Image");
            backBtn.ImageTransparentColor = Color.Magenta;
            backBtn.Name = "backBtn";
            backBtn.ShowDropDownArrow = false;
            backBtn.Size = new Size(36, 20);
            backBtn.Text = "Back";
            backBtn.Click += backBtn_Click;
            // 
            // homeBtn
            // 
            homeBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            homeBtn.Image = (Image)resources.GetObject("homeBtn.Image");
            homeBtn.ImageTransparentColor = Color.Magenta;
            homeBtn.Name = "homeBtn";
            homeBtn.ShowDropDownArrow = false;
            homeBtn.Size = new Size(44, 20);
            homeBtn.Text = "Home";
            homeBtn.Click += homeBtn_Click;
            // 
            // tasksBtn
            // 
            tasksBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tasksBtn.Image = (Image)resources.GetObject("tasksBtn.Image");
            tasksBtn.ImageTransparentColor = Color.Magenta;
            tasksBtn.Name = "tasksBtn";
            tasksBtn.ShowDropDownArrow = false;
            tasksBtn.Size = new Size(38, 20);
            tasksBtn.Text = "Tasks";
            tasksBtn.ToolTipText = "Apps";
            tasksBtn.Click += tasksBtn_Click;
            // 
            // screenBox
            // 
            screenBox.BackColor = Color.Transparent;
            screenBox.Location = new Point(0, 0);
            screenBox.Name = "screenBox";
            screenBox.Size = new Size(240, 320);
            screenBox.TabIndex = 0;
            screenBox.TabStop = false;
            screenBox.Click += clickScreen;
            screenBox.MouseDown += mouseDown;
            screenBox.MouseUp += mouseUp;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 200;
            timer1.Tick += timerTick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { testToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(94, 26);
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(93, 22);
            testToolStripMenuItem.Text = "test";
            // 
            // tabs
            // 
            tabs.Controls.Add(screenPage);
            tabs.Controls.Add(consoleTab);
            tabs.Controls.Add(deviceControl);
            tabs.Controls.Add(settingsPage);
            tabs.Location = new Point(0, 0);
            tabs.Margin = new Padding(0);
            tabs.Name = "tabs";
            tabs.Padding = new Point(0, 0);
            tabs.SelectedIndex = 0;
            tabs.Size = new Size(248, 348);
            tabs.TabIndex = 1;
            tabs.KeyDown += keyPress;
            // 
            // screenPage
            // 
            screenPage.Controls.Add(connectBtn);
            screenPage.Controls.Add(screenBox);
            screenPage.Location = new Point(4, 24);
            screenPage.Name = "screenPage";
            screenPage.Padding = new Padding(3);
            screenPage.Size = new Size(240, 320);
            screenPage.TabIndex = 0;
            screenPage.Text = "Screen";
            screenPage.UseVisualStyleBackColor = true;
            // 
            // connectBtn
            // 
            connectBtn.Location = new Point(84, 291);
            connectBtn.Name = "connectBtn";
            connectBtn.Size = new Size(75, 23);
            connectBtn.TabIndex = 1;
            connectBtn.Text = "Connect";
            connectBtn.UseVisualStyleBackColor = true;
            connectBtn.Click += connectBtn_Click;
            // 
            // consoleTab
            // 
            consoleTab.Controls.Add(consoleInput);
            consoleTab.Controls.Add(consoleOutput);
            consoleTab.Location = new Point(4, 24);
            consoleTab.Name = "consoleTab";
            consoleTab.Padding = new Padding(3);
            consoleTab.Size = new Size(240, 320);
            consoleTab.TabIndex = 3;
            consoleTab.Text = "Console";
            consoleTab.UseVisualStyleBackColor = true;
            // 
            // consoleInput
            // 
            consoleInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            consoleInput.ForeColor = SystemColors.WindowText;
            consoleInput.Location = new Point(0, 297);
            consoleInput.Name = "consoleInput";
            consoleInput.Size = new Size(240, 23);
            consoleInput.TabIndex = 1;
            consoleInput.KeyDown += consoleInput_KeyDown;
            // 
            // consoleOutput
            // 
            consoleOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            consoleOutput.BackColor = Color.Black;
            consoleOutput.Font = new Font("Consolas", 9F);
            consoleOutput.ForeColor = Color.White;
            consoleOutput.Location = new Point(0, 0);
            consoleOutput.Name = "consoleOutput";
            consoleOutput.ReadOnly = true;
            consoleOutput.Size = new Size(240, 294);
            consoleOutput.TabIndex = 0;
            consoleOutput.Text = "";
            // 
            // deviceControl
            // 
            deviceControl.Controls.Add(rootBtn);
            deviceControl.Controls.Add(powerBtn);
            deviceControl.Controls.Add(powerText);
            deviceControl.Controls.Add(powerDrpDwn);
            deviceControl.Controls.Add(button2);
            deviceControl.Location = new Point(4, 24);
            deviceControl.Name = "deviceControl";
            deviceControl.Padding = new Padding(3);
            deviceControl.Size = new Size(240, 320);
            deviceControl.TabIndex = 2;
            deviceControl.Text = "Device";
            deviceControl.UseVisualStyleBackColor = true;
            // 
            // rootBtn
            // 
            rootBtn.Location = new Point(75, 153);
            rootBtn.Name = "rootBtn";
            rootBtn.Size = new Size(75, 23);
            rootBtn.TabIndex = 8;
            rootBtn.Text = "Root";
            rootBtn.UseVisualStyleBackColor = true;
            rootBtn.Click += rootBtn_Click;
            // 
            // powerBtn
            // 
            powerBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            powerBtn.Location = new Point(75, 245);
            powerBtn.Name = "powerBtn";
            powerBtn.Size = new Size(75, 23);
            powerBtn.TabIndex = 7;
            powerBtn.Text = "Set Power";
            powerBtn.UseVisualStyleBackColor = true;
            powerBtn.Click += powerBtn_ClickAsync;
            // 
            // powerText
            // 
            powerText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            powerText.AutoSize = true;
            powerText.Location = new Point(91, 198);
            powerText.Name = "powerText";
            powerText.Size = new Size(40, 15);
            powerText.TabIndex = 6;
            powerText.Text = "Power";
            // 
            // powerDrpDwn
            // 
            powerDrpDwn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            powerDrpDwn.DropDownStyle = ComboBoxStyle.DropDownList;
            powerDrpDwn.FormattingEnabled = true;
            powerDrpDwn.Items.AddRange(new object[] { "Reboot", "Reboot (Recovery)", "Reboot (Bootloader)", "Reboot (Sideload)", "Shutdown" });
            powerDrpDwn.Location = new Point(52, 216);
            powerDrpDwn.Name = "powerDrpDwn";
            powerDrpDwn.Size = new Size(121, 23);
            powerDrpDwn.TabIndex = 5;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(75, 291);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Install APK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += InstallAPKBtn;
            // 
            // settingsPage
            // 
            settingsPage.Controls.Add(label1);
            settingsPage.Controls.Add(button1);
            settingsPage.Controls.Add(FPSLabel);
            settingsPage.Controls.Add(textBox1);
            settingsPage.Location = new Point(4, 24);
            settingsPage.Name = "settingsPage";
            settingsPage.Padding = new Padding(3);
            settingsPage.Size = new Size(240, 320);
            settingsPage.TabIndex = 1;
            settingsPage.Text = "Settings";
            settingsPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(33, 98);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 3;
            label1.Text = "Note: Due to the way this works, \r\nlow ms may crash the device.";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(76, 72);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Set";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SetMPFBtn;
            // 
            // FPSLabel
            // 
            FPSLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FPSLabel.AutoSize = true;
            FPSLabel.Location = new Point(53, 25);
            FPSLabel.Name = "FPSLabel";
            FPSLabel.Size = new Size(127, 15);
            FPSLabel.TabIndex = 1;
            FPSLabel.Text = "Milliseconds per frame";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(64, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tasksBtn, homeBtn, backBtn, inputStartBtn, volDropDown });
            statusStrip1.Location = new Point(0, 345);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(246, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // volDropDown
            // 
            volDropDown.Alignment = ToolStripItemAlignment.Right;
            volDropDown.DisplayStyle = ToolStripItemDisplayStyle.Text;
            volDropDown.DropDownItems.AddRange(new ToolStripItem[] { volumeUpBtn, volumeDownBtn, volumeMuteBtn });
            volDropDown.Image = (Image)resources.GetObject("volDropDown.Image");
            volDropDown.ImageTransparentColor = Color.Magenta;
            volDropDown.Name = "volDropDown";
            volDropDown.Size = new Size(60, 20);
            volDropDown.Text = "Volume";
            // 
            // volumeUpBtn
            // 
            volumeUpBtn.Name = "volumeUpBtn";
            volumeUpBtn.Size = new Size(180, 22);
            volumeUpBtn.Text = "Volume Up";
            volumeUpBtn.Click += volumeUpBtn_Click;
            // 
            // volumeDownBtn
            // 
            volumeDownBtn.Name = "volumeDownBtn";
            volumeDownBtn.Size = new Size(180, 22);
            volumeDownBtn.Text = "Volume Down";
            volumeDownBtn.Click += volumeDownBtn_Click;
            // 
            // volumeMuteBtn
            // 
            volumeMuteBtn.Name = "volumeMuteBtn";
            volumeMuteBtn.Size = new Size(180, 22);
            volumeMuteBtn.Text = "Mute";
            volumeMuteBtn.Click += volumeMuteBtn_Click;
            // 
            // inputStartBtn
            // 
            inputStartBtn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            inputStartBtn.Image = (Image)resources.GetObject("inputStartBtn.Image");
            inputStartBtn.ImageTransparentColor = Color.Magenta;
            inputStartBtn.Name = "inputStartBtn";
            inputStartBtn.ShowDropDownArrow = false;
            inputStartBtn.Size = new Size(39, 20);
            inputStartBtn.Text = "Input";
            inputStartBtn.Click += inputStartBtn_Click;
            // 
            // deviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 367);
            Controls.Add(statusStrip1);
            Controls.Add(tabs);
            MaximizeBox = false;
            Name = "deviceForm";
            Text = "Scuffed ADB Device Control";
            Load += deviceForm_Load;
            ((System.ComponentModel.ISupportInitialize)screenBox).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            tabs.ResumeLayout(false);
            screenPage.ResumeLayout(false);
            consoleTab.ResumeLayout(false);
            consoleTab.PerformLayout();
            deviceControl.ResumeLayout(false);
            deviceControl.PerformLayout();
            settingsPage.ResumeLayout(false);
            settingsPage.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox screenBox;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem testToolStripMenuItem;
        private TabControl tabs;
        private TabPage screenPage;
        private TabPage settingsPage;
        private Label FPSLabel;
        private TextBox textBox1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private TabPage deviceControl;
        private Button button2;
        private Label powerText;
        private ComboBox powerDrpDwn;
        private Button powerBtn;
        private Button connectBtn;
        private Label label1;
        private TabPage consoleTab;
        private TextBox consoleInput;
        private RichTextBox consoleOutput;
        private Button rootBtn;
        private StatusStrip statusStrip1;
        private ToolStripDropDownButton volDropDown;
        private ToolStripMenuItem volumeUpBtn;
        private ToolStripMenuItem volumeDownBtn;
        private ToolStripMenuItem volumeMuteBtn;
    }
}