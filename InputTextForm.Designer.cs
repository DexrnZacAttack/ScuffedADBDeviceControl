namespace ADBScuffedMirroring
{
    partial class InputTextForm
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
            inputTextBox = new RichTextBox();
            inputBtn = new Button();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(0, -1);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(324, 142);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "";
            // 
            // inputBtn
            // 
            inputBtn.Location = new Point(123, 147);
            inputBtn.Name = "inputBtn";
            inputBtn.Size = new Size(75, 23);
            inputBtn.TabIndex = 1;
            inputBtn.Text = "Input";
            inputBtn.UseVisualStyleBackColor = true;
            inputBtn.Click += inputBtn_Click;
            // 
            // InputTextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 175);
            Controls.Add(inputBtn);
            Controls.Add(inputTextBox);
            Name = "InputTextForm";
            Text = "InputTextForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox inputTextBox;
        private Button inputBtn;
    }
}