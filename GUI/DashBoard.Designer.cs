namespace GUI
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            pictureBox7 = new PictureBox();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            textBox1 = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 53);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(172, 28);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Panel";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RoyalBlue;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 574);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 473);
            label8.Name = "label8";
            label8.Size = new Size(160, 21);
            label8.TabIndex = 7;
            label8.Text = "WELCOME USER BOB";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(58, 405);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(61, 50);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 6;
            pictureBox7.TabStop = false;
            // 
            // button4
            // 
            button4.Location = new Point(27, 313);
            button4.Name = "button4";
            button4.Size = new Size(131, 28);
            button4.TabIndex = 5;
            button4.Text = "LOGOUT";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(27, 165);
            button3.Name = "button3";
            button3.Size = new Size(131, 28);
            button3.TabIndex = 4;
            button3.Text = "INVENTORY";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(27, 212);
            button2.Name = "button2";
            button2.Size = new Size(131, 30);
            button2.TabIndex = 3;
            button2.Text = "PROMOS";
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(46, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(27, 262);
            button1.Name = "button1";
            button1.Size = new Size(131, 28);
            button1.TabIndex = 1;
            button1.Text = "SHOP";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(27, 120);
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.No;
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "HOME";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(954, 60);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(377, 3);
            label2.Name = "label2";
            label2.Size = new Size(165, 37);
            label2.TabIndex = 0;
            label2.Text = "INVENTORY";
            // 
            // panel4
            // 
            panel4.BackColor = Color.RoyalBlue;
            panel4.Location = new Point(200, 107);
            panel4.Name = "panel4";
            panel4.Size = new Size(951, 517);
            panel4.TabIndex = 3;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 627);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashBoard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += DashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Panel panel4;
        private Label label2;
        private Label label8;
        private PictureBox pictureBox7;
    }
}