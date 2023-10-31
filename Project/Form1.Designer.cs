namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartButton = new Button();
            ListTitles = new ListBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(637, 24);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(89, 32);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // ListTitles
            // 
            ListTitles.FormattingEnabled = true;
            ListTitles.ItemHeight = 15;
            ListTitles.Location = new Point(12, 12);
            ListTitles.Name = "ListTitles";
            ListTitles.Size = new Size(597, 454);
            ListTitles.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(637, 62);
            button2.Name = "button2";
            button2.Size = new Size(89, 28);
            button2.TabIndex = 2;
            button2.Text = "Abort";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 550);
            Controls.Add(button2);
            Controls.Add(ListTitles);
            Controls.Add(StartButton);
            Name = "Form1";
            Tag = "";
            Text = "NeRateShopper";
            ResumeLayout(false);
        }

        #endregion

        private Button StartButton;
        private ListBox ListTitles;
        private Button button2;
    }
}