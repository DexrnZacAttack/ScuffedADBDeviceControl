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
            button2 = new Button();
            button1 = new Button();
            FPSLabel = new Label();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)screenBox).BeginInit();
            contextMenuStrip1.SuspendLayout();
            tabs.SuspendLayout();
            screenPage.SuspendLayout();
            settingsPage.SuspendLayout();
            SuspendLayout();
            // 
            // screenBox
            // 
            screenBox.BackColor = Color.Black;
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
            settingsPage.Controls.Add(button2);
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
            // button2
            // 
            button2.Location = new Point(76, 291);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Install APK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += InstallAPKBtn;
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
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabs);
            MaximizeBox = false;
            Name = "imageForm";
            Text = "Scuffed ADB Screen Mirrorer";
            ((System.ComponentModel.ISupportInitialize)screenBox).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            tabs.ResumeLayout(false);
            screenPage.ResumeLayout(false);
            settingsPage.ResumeLayout(false);
            settingsPage.PerformLayout();
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
        private Button button2;
        private OpenFileDialog openFileDialog1;
    }
}