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
            screenBox = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            testToolStripMenuItem = new ToolStripMenuItem();
            tabs = new TabControl();
            screenPage = new TabPage();
            settingsPage = new TabPage();
            button1 = new Button();
            FPSLabel = new Label();
            textBox1 = new TextBox();
            deviceControl = new TabPage();
            powerBtn = new Button();
            powerText = new Label();
            powerDrpDwn = new ComboBox();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            connectBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)screenBox).BeginInit();
            contextMenuStrip1.SuspendLayout();
            tabs.SuspendLayout();
            screenPage.SuspendLayout();
            settingsPage.SuspendLayout();
            deviceControl.SuspendLayout();
            SuspendLayout();
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
            tabs.Controls.Add(settingsPage);
            tabs.Controls.Add(deviceControl);
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
            // settingsPage
            // 
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
            // button1
            // 
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
            FPSLabel.AutoSize = true;
            FPSLabel.Location = new Point(53, 25);
            FPSLabel.Name = "FPSLabel";
            FPSLabel.Size = new Size(127, 15);
            FPSLabel.TabIndex = 1;
            FPSLabel.Text = "Milliseconds per frame";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // deviceControl
            // 
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
            // powerBtn
            // 
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
            powerText.AutoSize = true;
            powerText.Location = new Point(91, 198);
            powerText.Name = "powerText";
            powerText.Size = new Size(40, 15);
            powerText.TabIndex = 6;
            powerText.Text = "Power";
            // 
            // powerDrpDwn
            // 
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
            button2.Location = new Point(75, 291);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Install APK";
            button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
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
            // deviceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(246, 347);
            Controls.Add(tabs);
            MaximizeBox = false;
            Name = "deviceForm";
            Text = "Scuffed ADB Device Control";
            ((System.ComponentModel.ISupportInitialize)screenBox).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            tabs.ResumeLayout(false);
            screenPage.ResumeLayout(false);
            settingsPage.ResumeLayout(false);
            settingsPage.PerformLayout();
            deviceControl.ResumeLayout(false);
            deviceControl.PerformLayout();
            ResumeLayout(false);
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
    }
}