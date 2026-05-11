namespace ProductForm
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            txtpid1 = new TextBox();
            label3 = new Label();
            txtpname1 = new TextBox();
            label4 = new Label();
            comboUnit1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            quantity1 = new NumericUpDown();
            txtcustomer = new TextBox();
            btnprod1 = new Button();
            btnavail1 = new Button();
            btnhistory1 = new Button();
            btnadd1 = new Button();
            btnclear1 = new Button();
            btnprev1 = new Button();
            btnnext1 = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)quantity1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(252, 205, 42);
            label1.Font = new Font("Bookman Old Style", 42.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 121, 40);
            label1.Location = new Point(220, 31);
            label1.Name = "label1";
            label1.Size = new Size(346, 67);
            label1.TabIndex = 0;
            label1.Text = "Stock OUT";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.CalendarFont = new Font("Verdana", 9.75F, FontStyle.Bold);
            dateTimePicker1.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(600, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(52, 121, 40);
            label2.Location = new Point(89, 159);
            label2.Name = "label2";
            label2.Size = new Size(109, 18);
            label2.TabIndex = 2;
            label2.Text = "Product ID:";
            // 
            // txtpid1
            // 
            txtpid1.Font = new Font("Verdana", 12F);
            txtpid1.Location = new Point(215, 150);
            txtpid1.Name = "txtpid1";
            txtpid1.Size = new Size(309, 27);
            txtpid1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(52, 121, 40);
            label3.Location = new Point(59, 202);
            label3.Name = "label3";
            label3.Size = new Size(139, 18);
            label3.TabIndex = 4;
            label3.Text = "Product Name:";
            // 
            // txtpname1
            // 
            txtpname1.Font = new Font("Verdana", 12F);
            txtpname1.Location = new Point(215, 193);
            txtpname1.Name = "txtpname1";
            txtpname1.Size = new Size(309, 27);
            txtpname1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 121, 40);
            label4.Location = new Point(109, 242);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 6;
            label4.Text = "Quantity:";
            label4.Click += label4_Click;
            // 
            // comboUnit1
            // 
            comboUnit1.Font = new Font("Verdana", 12F);
            comboUnit1.FormattingEnabled = true;
            comboUnit1.Location = new Point(215, 272);
            comboUnit1.Name = "comboUnit1";
            comboUnit1.Size = new Size(309, 26);
            comboUnit1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(52, 121, 40);
            label5.Location = new Point(149, 280);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 8;
            label5.Text = "Unit:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 121, 40);
            label6.Location = new Point(99, 319);
            label6.Name = "label6";
            label6.Size = new Size(99, 18);
            label6.TabIndex = 9;
            label6.Text = "Customer:";
            // 
            // quantity1
            // 
            quantity1.Font = new Font("Verdana", 12F);
            quantity1.Location = new Point(215, 233);
            quantity1.Name = "quantity1";
            quantity1.Size = new Size(309, 27);
            quantity1.TabIndex = 10;
            // 
            // txtcustomer
            // 
            txtcustomer.Font = new Font("Verdana", 12F);
            txtcustomer.Location = new Point(215, 310);
            txtcustomer.Name = "txtcustomer";
            txtcustomer.Size = new Size(309, 27);
            txtcustomer.TabIndex = 11;
            // 
            // btnprod1
            // 
            btnprod1.BackColor = Color.FromArgb(52, 121, 40);
            btnprod1.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            btnprod1.ForeColor = Color.FromArgb(244, 246, 255);
            btnprod1.Location = new Point(590, 161);
            btnprod1.Name = "btnprod1";
            btnprod1.Size = new Size(176, 46);
            btnprod1.TabIndex = 12;
            btnprod1.Text = "Product";
            btnprod1.UseVisualStyleBackColor = false;
            btnprod1.Click += btnprod1_Click;
            // 
            // btnavail1
            // 
            btnavail1.BackColor = Color.FromArgb(52, 121, 40);
            btnavail1.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            btnavail1.ForeColor = Color.FromArgb(244, 246, 255);
            btnavail1.Location = new Point(590, 228);
            btnavail1.Name = "btnavail1";
            btnavail1.Size = new Size(176, 55);
            btnavail1.TabIndex = 13;
            btnavail1.Text = "Available Products";
            btnavail1.UseVisualStyleBackColor = false;
            btnavail1.Click += btnavail1_Click;
            // 
            // btnhistory1
            // 
            btnhistory1.BackColor = Color.FromArgb(52, 121, 40);
            btnhistory1.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            btnhistory1.ForeColor = Color.FromArgb(244, 246, 255);
            btnhistory1.Location = new Point(590, 304);
            btnhistory1.Name = "btnhistory1";
            btnhistory1.Size = new Size(176, 49);
            btnhistory1.TabIndex = 14;
            btnhistory1.Text = "Product History";
            btnhistory1.UseVisualStyleBackColor = false;
            btnhistory1.Click += btnhistory1_Click;
            // 
            // btnadd1
            // 
            btnadd1.BackColor = Color.FromArgb(52, 121, 40);
            btnadd1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnadd1.ForeColor = Color.FromArgb(244, 246, 255);
            btnadd1.Location = new Point(166, 403);
            btnadd1.Name = "btnadd1";
            btnadd1.Size = new Size(94, 48);
            btnadd1.TabIndex = 15;
            btnadd1.Text = "Add";
            btnadd1.UseVisualStyleBackColor = false;
            btnadd1.Click += btnadd1_Click;
            // 
            // btnclear1
            // 
            btnclear1.BackColor = Color.FromArgb(52, 121, 40);
            btnclear1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnclear1.ForeColor = Color.FromArgb(244, 246, 255);
            btnclear1.Location = new Point(285, 403);
            btnclear1.Name = "btnclear1";
            btnclear1.Size = new Size(94, 48);
            btnclear1.TabIndex = 16;
            btnclear1.Text = "Clear";
            btnclear1.UseVisualStyleBackColor = false;
            btnclear1.Click += btnclear1_Click;
            // 
            // btnprev1
            // 
            btnprev1.BackColor = Color.FromArgb(52, 121, 40);
            btnprev1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnprev1.ForeColor = Color.FromArgb(244, 246, 255);
            btnprev1.Location = new Point(457, 403);
            btnprev1.Name = "btnprev1";
            btnprev1.Size = new Size(94, 48);
            btnprev1.TabIndex = 17;
            btnprev1.Text = "Previous";
            btnprev1.UseVisualStyleBackColor = false;
            btnprev1.Click += btnprev1_Click;
            // 
            // btnnext1
            // 
            btnnext1.BackColor = Color.FromArgb(52, 121, 40);
            btnnext1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnnext1.ForeColor = Color.FromArgb(244, 246, 255);
            btnnext1.Location = new Point(572, 403);
            btnnext1.Name = "btnnext1";
            btnnext1.Size = new Size(94, 48);
            btnnext1.TabIndex = 18;
            btnnext1.Text = "Next";
            btnnext1.UseVisualStyleBackColor = false;
            btnnext1.Click += btnnext1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 205, 42);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-12, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(852, 120);
            panel1.TabIndex = 48;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 230);
            ClientSize = new Size(821, 487);
            Controls.Add(btnnext1);
            Controls.Add(btnprev1);
            Controls.Add(btnclear1);
            Controls.Add(btnadd1);
            Controls.Add(btnhistory1);
            Controls.Add(btnavail1);
            Controls.Add(btnprod1);
            Controls.Add(txtcustomer);
            Controls.Add(quantity1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboUnit1);
            Controls.Add(label4);
            Controls.Add(txtpname1);
            Controls.Add(label3);
            Controls.Add(txtpid1);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)quantity1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox txtpid1;
        private Label label3;
        private TextBox txtpname1;
        private Label label4;
        private ComboBox comboUnit1;
        private Label label5;
        private Label label6;
        private NumericUpDown quantity1;
        private TextBox txtcustomer;
        private Button btnprod1;
        private Button btnavail1;
        private Button btnhistory1;
        private Button btnadd1;
        private Button btnclear1;
        private Button btnprev1;
        private Button btnnext1;
        private Panel panel1;
    }
}