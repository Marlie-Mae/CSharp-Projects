namespace ProductForm
{
    partial class Form5
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
            comboHistory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtsearch = new TextBox();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            btnexit1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboHistory
            // 
            comboHistory.BackColor = Color.FromArgb(255, 251, 230);
            comboHistory.Font = new Font("Verdana", 9F, FontStyle.Bold);
            comboHistory.ForeColor = Color.FromArgb(52, 121, 40);
            comboHistory.FormattingEnabled = true;
            comboHistory.Items.AddRange(new object[] { "Product", "Available Products", "Stock IN", "Stock OUT" });
            comboHistory.Location = new Point(792, 28);
            comboHistory.Name = "comboHistory";
            comboHistory.Size = new Size(148, 22);
            comboHistory.TabIndex = 14;
            comboHistory.SelectedIndexChanged += comboHistory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(52, 121, 40);
            label1.Location = new Point(190, 25);
            label1.Name = "label1";
            label1.Size = new Size(560, 75);
            label1.TabIndex = 13;
            label1.Text = "Product History";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(52, 121, 40);
            label2.Location = new Point(22, 152);
            label2.Name = "label2";
            label2.Size = new Size(69, 18);
            label2.TabIndex = 15;
            label2.Text = "Search";
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Verdana", 12F);
            txtsearch.Location = new Point(97, 143);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(347, 27);
            txtsearch.TabIndex = 16;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(865, 270);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(252, 205, 42);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboHistory);
            panel1.Location = new Point(-12, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 120);
            panel1.TabIndex = 49;
            // 
            // btnexit1
            // 
            btnexit1.BackColor = Color.FromArgb(52, 121, 40);
            btnexit1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit1.ForeColor = Color.FromArgb(244, 246, 255);
            btnexit1.Location = new Point(823, 490);
            btnexit1.Name = "btnexit1";
            btnexit1.Size = new Size(97, 43);
            btnexit1.TabIndex = 50;
            btnexit1.Text = "Exit";
            btnexit1.UseVisualStyleBackColor = false;
            btnexit1.Click += btnexit1_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 251, 230);
            ClientSize = new Size(950, 553);
            Controls.Add(btnexit1);
            Controls.Add(dataGridView1);
            Controls.Add(txtsearch);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboHistory;
        private Label label1;
        private Label label2;
        private TextBox txtsearch;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Button btnexit1;
    }
}