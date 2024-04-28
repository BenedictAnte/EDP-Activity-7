namespace GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(12, 224);
            button1.Name = "button1";
            button1.Size = new Size(145, 28);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(183, 224);
            button2.Name = "button2";
            button2.Size = new Size(145, 28);
            button2.TabIndex = 2;
            button2.Text = "Forgot Password";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(86, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 96);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 5;
            label2.Text = "PASSWORD";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 159);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(217, 23);
            textBox3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(398, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 386);
            label3.Name = "label3";
            label3.Size = new Size(476, 15);
            label3.TabIndex = 10;
            label3.Text = "CREDITS: TO THE OWNERS OF THE LOGOS, BRANDS USED I DO NOT OWN ANY OF THESE";
            // 
            // button3
            // 
            button3.Location = new Point(12, 273);
            button3.Name = "button3";
            button3.Size = new Size(145, 26);
            button3.TabIndex = 11;
            button3.Text = "Report Generation ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(758, 410);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Login";
            RightToLeft = RightToLeft.No;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private Label label3;
        private Button button3;
    }
}
