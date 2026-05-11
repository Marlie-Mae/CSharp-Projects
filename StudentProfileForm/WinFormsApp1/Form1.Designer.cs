namespace WinFormsApp1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            button5 = new Button();
            label6 = new Label();
            label7 = new Label();
            textBox6 = new TextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            textBox1.Location = new Point(162, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 33);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            textBox2.Location = new Point(162, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 33);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            textBox3.Location = new Point(162, 320);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 33);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(244, 246, 255);
            label1.Location = new Point(40, 289);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 3;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(244, 246, 255);
            label2.Location = new Point(41, 250);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 4;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(244, 246, 255);
            label3.Location = new Point(41, 328);
            label3.Name = "label3";
            label3.Size = new Size(102, 25);
            label3.TabIndex = 5;
            label3.Text = "Phone No.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(235, 131, 23);
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(244, 246, 255);
            button1.Location = new Point(267, 500);
            button1.Name = "button1";
            button1.Size = new Size(103, 44);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(235, 131, 23);
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(244, 246, 255);
            button2.Location = new Point(438, 500);
            button2.Name = "button2";
            button2.Size = new Size(103, 44);
            button2.TabIndex = 7;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(235, 131, 23);
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(244, 246, 255);
            button3.Location = new Point(601, 500);
            button3.Name = "button3";
            button3.Size = new Size(103, 44);
            button3.TabIndex = 8;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(235, 131, 23);
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(244, 246, 255);
            button4.Location = new Point(759, 500);
            button4.Name = "button4";
            button4.Size = new Size(103, 44);
            button4.TabIndex = 9;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Location = new Point(453, 242);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(662, 206);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(244, 246, 255);
            label4.Location = new Point(41, 211);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 12;
            label4.Text = "Student ID";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            textBox4.Location = new Point(162, 203);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 33);
            textBox4.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(244, 246, 255);
            label5.Location = new Point(41, 406);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 14;
            label5.Text = "Gender";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(162, 398);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 33);
            comboBox1.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(453, 185);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(553, 33);
            textBox5.TabIndex = 16;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(235, 131, 23);
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(244, 246, 255);
            button5.Location = new Point(1012, 178);
            button5.Name = "button5";
            button5.Size = new Size(103, 44);
            button5.TabIndex = 17;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Calligraphy", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(16, 55, 92);
            label6.Location = new Point(382, 43);
            label6.Name = "label6";
            label6.Size = new Size(427, 62);
            label6.TabIndex = 18;
            label6.Text = "Student Profile";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(244, 246, 255);
            label7.Location = new Point(41, 367);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 20;
            label7.Text = "Address";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            textBox6.Location = new Point(162, 359);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 33);
            textBox6.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(243, 198, 35);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1168, 147);
            panel1.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 55, 92);
            ClientSize = new Size(1168, 590);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(button5);
            Controls.Add(textBox5);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Student Profile";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private Button button5;
        private Label label6;
        private Label label7;
        private TextBox textBox6;
        private Panel panel1;
    }
}
