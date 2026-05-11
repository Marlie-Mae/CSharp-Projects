namespace ProductForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtpid = new TextBox();
            txtpname = new TextBox();
            txtpdesc = new TextBox();
            btnadd = new Button();
            btnupdate = new Button();
            btndelete = new Button();
            btclear = new Button();
            comboHistory = new ComboBox();
            btnprev = new Button();
            btnnext = new Button();
            btnexit = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 251, 230);
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(52, 121, 40);
            label2.Location = new Point(125, 186);
            label2.Name = "label2";
            label2.Size = new Size(109, 18);
            label2.TabIndex = 1;
            label2.Text = "Product ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 251, 230);
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(52, 121, 40);
            label3.Location = new Point(95, 230);
            label3.Name = "label3";
            label3.Size = new Size(139, 18);
            label3.TabIndex = 2;
            label3.Text = "Product Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 251, 230);
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 121, 40);
            label4.Location = new Point(48, 275);
            label4.Name = "label4";
            label4.Size = new Size(186, 18);
            label4.TabIndex = 3;
            label4.Text = "Product Description:";
            // 
            // txtpid
            // 
            txtpid.BackColor = Color.White;
            txtpid.Font = new Font("Verdana", 12F);
            txtpid.Location = new Point(247, 181);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(262, 27);
            txtpid.TabIndex = 4;
            // 
            // txtpname
            // 
            txtpname.BackColor = Color.White;
            txtpname.Font = new Font("Verdana", 12F);
            txtpname.Location = new Point(247, 225);
            txtpname.Name = "txtpname";
            txtpname.Size = new Size(262, 27);
            txtpname.TabIndex = 5;
            // 
            // txtpdesc
            // 
            txtpdesc.BackColor = Color.White;
            txtpdesc.Font = new Font("Verdana", 12F);
            txtpdesc.Location = new Point(247, 270);
            txtpdesc.Name = "txtpdesc";
            txtpdesc.Size = new Size(262, 27);
            txtpdesc.TabIndex = 6;
            // 
            // btnadd
            // 
            btnadd.BackColor = Color.FromArgb(52, 121, 40);
            btnadd.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btnadd.ForeColor = Color.FromArgb(244, 246, 255);
            btnadd.Location = new Point(595, 151);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(90, 36);
            btnadd.TabIndex = 7;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = false;
            btnadd.Click += btnadd_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.FromArgb(52, 121, 40);
            btnupdate.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btnupdate.ForeColor = Color.FromArgb(244, 246, 255);
            btnupdate.Location = new Point(595, 196);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(90, 36);
            btnupdate.TabIndex = 8;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btndelete
            // 
            btndelete.BackColor = Color.FromArgb(52, 121, 40);
            btndelete.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btndelete.ForeColor = Color.FromArgb(244, 246, 255);
            btndelete.Location = new Point(595, 242);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(90, 36);
            btndelete.TabIndex = 9;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = false;
            btndelete.Click += btndelete_Click;
            // 
            // btclear
            // 
            btclear.BackColor = Color.FromArgb(52, 121, 40);
            btclear.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btclear.ForeColor = Color.FromArgb(244, 246, 255);
            btclear.Location = new Point(595, 289);
            btclear.Name = "btclear";
            btclear.Size = new Size(90, 36);
            btclear.TabIndex = 10;
            btclear.Text = "Clear";
            btclear.UseVisualStyleBackColor = false;
            btclear.Click += btnclear_Click;
            // 
            // comboHistory
            // 
            comboHistory.BackColor = Color.FromArgb(255, 251, 230);
            comboHistory.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboHistory.ForeColor = Color.FromArgb(52, 121, 40);
            comboHistory.FormattingEnabled = true;
            comboHistory.ItemHeight = 14;
            comboHistory.Items.AddRange(new object[] { "Available Products", "Stock IN", "Stock OUT", "Product History" });
            comboHistory.Location = new Point(606, 25);
            comboHistory.Name = "comboHistory";
            comboHistory.Size = new Size(148, 22);
            comboHistory.TabIndex = 11;
            comboHistory.SelectedIndexChanged += comboHistory_SelectedIndexChanged;
            // 
            // btnprev
            // 
            btnprev.BackColor = Color.FromArgb(52, 121, 40);
            btnprev.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnprev.ForeColor = Color.FromArgb(244, 246, 255);
            btnprev.Location = new Point(227, 357);
            btnprev.Name = "btnprev";
            btnprev.Size = new Size(95, 44);
            btnprev.TabIndex = 12;
            btnprev.Text = "Previous";
            btnprev.UseVisualStyleBackColor = false;
            btnprev.Click += btnprev_Click;
            // 
            // btnnext
            // 
            btnnext.BackColor = Color.FromArgb(52, 121, 40);
            btnnext.Font = new Font("Verdana", 12F, FontStyle.Bold);
            btnnext.ForeColor = Color.FromArgb(244, 246, 255);
            btnnext.Location = new Point(423, 357);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(95, 44);
            btnnext.TabIndex = 13;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = false;
            btnnext.Click += btnnext_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(52, 121, 40);
            btnexit.Font = new Font("Verdana", 9.75F, FontStyle.Bold);
            btnexit.ForeColor = Color.FromArgb(244, 246, 255);
            btnexit.Location = new Point(595, 334);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(90, 36);
            btnexit.TabIndex = 14;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(252, 205, 42);
            label1.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 121, 40);
            label1.Location = new Point(236, 21);
            label1.Name = "label1";
            label1.Size = new Size(292, 75);
            label1.TabIndex = 0;
            label1.Text = "Product";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 205, 42);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(-12, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 120);
            panel1.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(252, 205, 42);
            label5.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(52, 121, 40);
            label5.Location = new Point(243, 26);
            label5.Name = "label5";
            label5.Size = new Size(0, 75);
            label5.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 251, 230);
            ClientSize = new Size(775, 435);
            Controls.Add(label1);
            Controls.Add(btnexit);
            Controls.Add(btnnext);
            Controls.Add(btnprev);
            Controls.Add(comboHistory);
            Controls.Add(btclear);
            Controls.Add(btndelete);
            Controls.Add(btnupdate);
            Controls.Add(btnadd);
            Controls.Add(txtpdesc);
            Controls.Add(txtpname);
            Controls.Add(txtpid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtpid;
        private TextBox txtpname;
        private TextBox txtpdesc;
        private Button btnadd;
        private Button btnupdate;
        private Button btndelete;
        private Button btclear;
        private ComboBox comboHistory;
        private Button btnprev;
        private Button btnnext;
        private Button btnexit;
        private Label label1;
        private Panel panel1;
        private Label label5;
    }
}
