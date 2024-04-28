namespace GUI
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            button4 = new Button();
            label7 = new Label();
            dataGridView2 = new DataGridView();
            dataGridView3 = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 255, 128);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(15, 122);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 1;
            label2.Text = "BORROW GAMES ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(15, 158);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 2;
            label3.Text = "TRANSACTIONS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(255, 255, 128);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(15, 187);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 4;
            label5.Text = "STOCKS";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(123, 118);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "SHOW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(122, 154);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "SHOW";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(88, 183);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "SHOW";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(380, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(366, 113);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(255, 255, 128);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(506, 9);
            label6.Name = "label6";
            label6.Size = new Size(121, 15);
            label6.TabIndex = 10;
            label6.Text = "REPORT GENERATION";
            // 
            // button4
            // 
            button4.Location = new Point(12, 262);
            button4.Name = "button4";
            button4.Size = new Size(162, 23);
            button4.TabIndex = 11;
            button4.Text = "BORROW GAME REPORT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(255, 255, 128);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(12, 229);
            label7.Name = "label7";
            label7.Size = new Size(180, 15);
            label7.TabIndex = 12;
            label7.Text = "IMPORT TO MS EXCEL TEMPLATE";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(380, 159);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(366, 123);
            dataGridView2.TabIndex = 13;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = Color.FromArgb(255, 255, 128);
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(380, 288);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(366, 150);
            dataGridView3.TabIndex = 14;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(12, 299);
            button5.Name = "button5";
            button5.Size = new Size(162, 23);
            button5.TabIndex = 15;
            button5.Text = "TRANSACTION REPORT";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(12, 339);
            button6.Name = "button6";
            button6.Size = new Size(162, 23);
            button6.TabIndex = 16;
            button6.Text = "STOCKS REPORT";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.RoyalBlue;
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button button4;
        private Label label7;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private Button button5;
        private Button button6;
    }
}