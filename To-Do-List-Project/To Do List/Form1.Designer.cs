namespace To_Do_List
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
            label1 = new Label();
            label2 = new Label();
            txtTaskName = new TextBox();
            label3 = new Label();
            dtpDueDate = new DateTimePicker();
            btnAddTask = new Button();
            dgvTasks = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            lblCompleted = new Label();
            lblPending = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F);
            label1.Location = new Point(34, 16);
            label1.Name = "label1";
            label1.Size = new Size(310, 46);
            label1.TabIndex = 0;
            label1.Text = "To Do List Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(34, 92);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 1;
            label2.Text = "New Task:";
            // 
            // txtTaskName
            // 
            txtTaskName.Font = new Font("Segoe UI", 15F);
            txtTaskName.Location = new Point(136, 89);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(360, 34);
            txtTaskName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(529, 92);
            label3.Name = "label3";
            label3.Size = new Size(57, 28);
            label3.TabIndex = 3;
            label3.Text = "Date:";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Segoe UI", 15F);
            dtpDueDate.Location = new Point(592, 89);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(158, 34);
            dtpDueDate.TabIndex = 4;
            // 
            // btnAddTask
            // 
            btnAddTask.Font = new Font("Segoe UI", 15F);
            btnAddTask.Location = new Point(136, 129);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(360, 37);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(34, 190);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.Size = new Size(734, 240);
            dgvTasks.TabIndex = 6;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(44, 450);
            label4.Name = "label4";
            label4.Size = new Size(113, 28);
            label4.TabIndex = 7;
            label4.Text = "Completed:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(301, 450);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 8;
            label5.Text = "Pending:";
            // 
            // lblCompleted
            // 
            lblCompleted.AutoSize = true;
            lblCompleted.Font = new Font("Segoe UI", 15F);
            lblCompleted.Location = new Point(148, 450);
            lblCompleted.Name = "lblCompleted";
            lblCompleted.Size = new Size(23, 28);
            lblCompleted.TabIndex = 9;
            lblCompleted.Text = "0";
            // 
            // lblPending
            // 
            lblPending.AutoSize = true;
            lblPending.Font = new Font("Segoe UI", 15F);
            lblPending.Location = new Point(379, 450);
            lblPending.Name = "lblPending";
            lblPending.Size = new Size(23, 28);
            lblPending.TabIndex = 10;
            lblPending.Text = "0";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 15F);
            btnClear.Location = new Point(621, 450);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(129, 37);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 506);
            Controls.Add(btnClear);
            Controls.Add(lblPending);
            Controls.Add(lblCompleted);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvTasks);
            Controls.Add(btnAddTask);
            Controls.Add(dtpDueDate);
            Controls.Add(label3);
            Controls.Add(txtTaskName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTaskName;
        private Label label3;
        private DateTimePicker dtpDueDate;
        private Button btnAddTask;
        private DataGridView dgvTasks;
        private Label label4;
        private Label label5;
        private Label lblCompleted;
        private Label lblPending;
        private Button btnClear;
    }
}
