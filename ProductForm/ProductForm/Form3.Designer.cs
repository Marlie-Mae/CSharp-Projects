namespace ProductForm
{
    partial class Form3
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
            btnprod = new Button();
            btnavail = new Button();
            btnhistory = new Button();
            txtsupplier = new TextBox();
            label6 = new Label();
            btnclear = new Button();
            btnadd = new Button();
            quantity = new NumericUpDown();
            comboUnit = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            txtpname = new TextBox();
            txtpid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnnext = new Button();
            btnprev = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)quantity).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(252, 205, 42);
            label1.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(52, 121, 40);
            label1.Location = new Point(255, 31);
            label1.Name = "label1";
            label1.Size = new Size(317, 75);
            label1.TabIndex = 2;
            label1.Text = "Stock IN";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AllowDrop = true;
            dateTimePicker1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(613, 26);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // btnprod
            // 
            btnprod.BackColor = Color.FromArgb(52, 121, 40);
            btnprod.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            btnprod.ForeColor = Color.FromArgb(244, 246, 255);
            btnprod.Location = new Point(591, 155);
            btnprod.Name = "btnprod";
            btnprod.Size = new Size(176, 46);
            btnprod.TabIndex = 16;
            btnprod.Text = "Product";
            btnprod.UseVisualStyleBackColor = false;
            btnprod.Click += btnprod_Click;
            // 
            // btnavail
            // 
            btnavail.BackColor = Color.FromArgb(52, 121, 40);
            btnavail.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            btnavail.ForeColor = Color.FromArgb(244, 246, 255);
            btnavail.Location = new Point(591, 222);
            btnavail.Name = "btnavail";
            btnavail.Size = new Size(176, 55);
            btnavail.TabIndex = 17;
            btnavail.Text = "Available Products";
            btnavail.UseVisualStyleBackColor = false;
            btnavail.Click += btnavail_Click;
            // 
            // btnhistory
            // 
            btnhistory.BackColor = Color.FromArgb(52, 121, 40);
            btnhistory.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
            btnhistory.ForeColor = Color.FromArgb(244, 246, 255);
            btnhistory.Location = new Point(591, 298);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(176, 49);
            btnhistory.TabIndex = 18;
            btnhistory.Text = "Product History";
            btnhistory.UseVisualStyleBackColor = false;
            btnhistory.Click += btnhistory_Click;
            // 
            // txtsupplier
            // 
            txtsupplier.BackColor = Color.White;
            txtsupplier.Font = new Font("Verdana", 12F);
            txtsupplier.Location = new Point(215, 310);
            txtsupplier.Name = "txtsupplier";
            txtsupplier.Size = new Size(309, 27);
            txtsupplier.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(52, 121, 40);
            label6.Location = new Point(113, 319);
            label6.Name = "label6";
            label6.Size = new Size(85, 18);
            label6.TabIndex = 43;
            label6.Text = "Supplier:";
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.FromArgb(52, 121, 40);
            btnclear.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnclear.ForeColor = Color.FromArgb(244, 246, 255);
            btnclear.Location = new Point(293, 403);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 48);
            btnclear.TabIndex = 42;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(52, 121, 40);
            btnadd.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnadd.ForeColor = Color.FromArgb(244, 246, 255);
            btnadd.Location = new Point(173, 403);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(94, 48);
            btnadd.TabIndex = 41;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // quantity
            // 
            quantity.BackColor = Color.White;
            quantity.Font = new Font("Verdana", 12F);
            quantity.Location = new Point(215, 233);
            quantity.Name = "quantity";
            quantity.Size = new Size(309, 27);
            quantity.TabIndex = 40;
            quantity.ValueChanged += quantity_ValueChanged;
            // 
            // comboUnit
            // 
            comboUnit.BackColor = Color.White;
            comboUnit.Font = new Font("Verdana", 12F);
            comboUnit.FormattingEnabled = true;
            comboUnit.Location = new Point(215, 272);
            comboUnit.Name = "comboUnit";
            comboUnit.Size = new Size(309, 26);
            comboUnit.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(52, 121, 40);
            label5.Location = new Point(149, 280);
            label5.Name = "label5";
            label5.Size = new Size(49, 18);
            label5.TabIndex = 38;
            label5.Text = "Unit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 121, 40);
            label4.Location = new Point(109, 242);
            label4.Name = "label4";
            label4.Size = new Size(89, 18);
            label4.TabIndex = 37;
            label4.Text = "Quantity:";
            // 
            // txtpname
            // 
            txtpname.BackColor = Color.White;
            txtpname.Font = new Font("Verdana", 12F);
            txtpname.Location = new Point(215, 193);
            txtpname.Name = "txtpname";
            txtpname.Size = new Size(309, 27);
            txtpname.TabIndex = 36;
            // 
            // txtpid
            // 
            txtpid.BackColor = Color.White;
            txtpid.Font = new Font("Verdana", 12F);
            txtpid.Location = new Point(215, 150);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(309, 27);
            txtpid.TabIndex = 35;
            txtpid.TextChanged += txtpid_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(52, 121, 40);
            label3.Location = new Point(59, 202);
            label3.Name = "label3";
            label3.Size = new Size(139, 18);
            label3.TabIndex = 34;
            label3.Text = "Product Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(52, 121, 40);
            label2.Location = new Point(89, 159);
            label2.Name = "label2";
            label2.Size = new Size(109, 18);
            label2.TabIndex = 33;
            label2.Text = "Product ID:";
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.FromArgb(52, 121, 40);
            btnnext.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnnext.ForeColor = Color.FromArgb(244, 246, 255);
            btnnext.Location = new Point(581, 403);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(94, 48);
            btnnext.TabIndex = 46;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // btnprev
            // 
            btnprev.BackColor = Color.FromArgb(52, 121, 40);
            btnprev.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnprev.ForeColor = Color.FromArgb(244, 246, 255);
            btnprev.Location = new Point(465, 403);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(94, 48);
            btnprev.TabIndex = 45;
            btnprev.Text = "Previous";
            btnprev.UseVisualStyleBackColor = false;
            btnprev.Click += btnprev_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 205, 42);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(-12, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 120);
            panel1.TabIndex = 47;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 230);
            ClientSize = new Size(821, 487);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            Controls.Add(txtsupplier);
            Controls.Add(label6);
            Controls.Add(btnclear);
            Controls.Add(btnadd);
            Controls.Add(quantity);
            Controls.Add(comboUnit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtpname);
            Controls.Add(txtpid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnhistory);
            Controls.Add(btnavail);
            Controls.Add(btnprod);
            Controls.Add(panel1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)quantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button btnprod;
        private Button btnavail;
        private Button btnhistory;
        private TextBox txtsupplier;
        private Label label6;
        private Button btnclear;
        private Button btnadd;
        private NumericUpDown quantity;
        private ComboBox comboUnit;
        private Label label5;
        private Label label4;
        private TextBox txtpname;
        private TextBox txtpid;
        private Label label3;
        private Label label2;
        private Button btnnext;
        private Button btnprev;
        private Panel panel1;
    }
}