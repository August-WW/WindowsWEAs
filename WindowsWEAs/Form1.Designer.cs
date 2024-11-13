namespace WindowsWEAs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            radioButton_AMBER = new RadioButton();
            radioButton_Emergency = new RadioButton();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            radioButton_National = new RadioButton();
            radioButton_Test = new RadioButton();
            radioButton_PublicSafety = new RadioButton();
            button_SendWEA = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // radioButton_AMBER
            // 
            radioButton_AMBER.AutoSize = true;
            radioButton_AMBER.ForeColor = SystemColors.ControlLightLight;
            radioButton_AMBER.Location = new Point(284, 197);
            radioButton_AMBER.Name = "radioButton_AMBER";
            radioButton_AMBER.RightToLeft = RightToLeft.No;
            radioButton_AMBER.Size = new Size(115, 24);
            radioButton_AMBER.TabIndex = 0;
            radioButton_AMBER.Text = "AMBER Alert";
            radioButton_AMBER.UseVisualStyleBackColor = true;
            // 
            // radioButton_Emergency
            // 
            radioButton_Emergency.AutoSize = true;
            radioButton_Emergency.ForeColor = SystemColors.ControlLightLight;
            radioButton_Emergency.Location = new Point(139, 197);
            radioButton_Emergency.Name = "radioButton_Emergency";
            radioButton_Emergency.RightToLeft = RightToLeft.No;
            radioButton_Emergency.Size = new Size(139, 24);
            radioButton_Emergency.TabIndex = 1;
            radioButton_Emergency.Text = "Emergency Alert";
            radioButton_Emergency.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(281, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 106);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(52, 227);
            richTextBox1.MaxLength = 360;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(561, 115);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // radioButton_National
            // 
            radioButton_National.AutoSize = true;
            radioButton_National.ForeColor = SystemColors.ControlLightLight;
            radioButton_National.Location = new Point(10, 197);
            radioButton_National.Name = "radioButton_National";
            radioButton_National.RightToLeft = RightToLeft.No;
            radioButton_National.Size = new Size(123, 24);
            radioButton_National.TabIndex = 5;
            radioButton_National.Text = "National Alert";
            radioButton_National.UseVisualStyleBackColor = true;
            // 
            // radioButton_Test
            // 
            radioButton_Test.AutoSize = true;
            radioButton_Test.ForeColor = SystemColors.ControlLightLight;
            radioButton_Test.Location = new Point(562, 197);
            radioButton_Test.Name = "radioButton_Test";
            radioButton_Test.RightToLeft = RightToLeft.No;
            radioButton_Test.Size = new Size(92, 24);
            radioButton_Test.TabIndex = 6;
            radioButton_Test.Text = "Test Alert";
            radioButton_Test.UseVisualStyleBackColor = true;
            // 
            // radioButton_PublicSafety
            // 
            radioButton_PublicSafety.AutoSize = true;
            radioButton_PublicSafety.ForeColor = SystemColors.ControlLightLight;
            radioButton_PublicSafety.Location = new Point(405, 197);
            radioButton_PublicSafety.Name = "radioButton_PublicSafety";
            radioButton_PublicSafety.RightToLeft = RightToLeft.No;
            radioButton_PublicSafety.Size = new Size(151, 24);
            radioButton_PublicSafety.TabIndex = 7;
            radioButton_PublicSafety.Text = "Public Safety Alert";
            radioButton_PublicSafety.UseVisualStyleBackColor = true;
            // 
            // button_SendWEA
            // 
            button_SendWEA.Location = new Point(10, 368);
            button_SendWEA.Name = "button_SendWEA";
            button_SendWEA.Size = new Size(644, 44);
            button_SendWEA.TabIndex = 9;
            button_SendWEA.Text = "Send WEA";
            button_SendWEA.UseVisualStyleBackColor = true;
            button_SendWEA.Click += button_SendWEA_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("VCR EAS", 15F);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(79, 12);
            label1.Name = "label1";
            label1.Size = new Size(507, 25);
            label1.TabIndex = 10;
            label1.Text = "Windows Wireless Emergency Alerts";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("VCR EAS", 11F);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(251, 45);
            label2.Name = "label2";
            label2.Size = new Size(163, 19);
            label2.TabIndex = 11;
            label2.Text = "by August Wolf";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(664, 421);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button_SendWEA);
            Controls.Add(radioButton_PublicSafety);
            Controls.Add(radioButton_Test);
            Controls.Add(radioButton_National);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton_Emergency);
            Controls.Add(radioButton_AMBER);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Windows Wireless Emergency Alerts";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton_AMBER;
        private RadioButton radioButton_Emergency;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private RadioButton radioButton_National;
        private RadioButton radioButton_Test;
        private RadioButton radioButton_PublicSafety;
        private Button button_SendWEA;
        private Label label1;
        private Label label2;
    }
}
