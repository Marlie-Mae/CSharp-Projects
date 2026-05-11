using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        // Connection string pointing to your ToDoDatabase.mdf
        string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Phil\source\repos\To Do List\To Do List\ToDoDatabase.mdf"";Integrated Security=True";

        // Track if we are editing an existing task
        private int selectedTaskId = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks(); //
        }

        public void LoadTasks()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    string query = "SELECT IsCompleted, TaskDescription, DueDate, Id FROM Tasks"; //
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvTasks.DataSource = dt;
                    FormatGrid();
                    UpdateCounts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void FormatGrid()
        {
            dgvTasks.Columns["IsCompleted"].HeaderText = "Status";
            dgvTasks.Columns["TaskDescription"].HeaderText = "Task Description";
            dgvTasks.Columns["DueDate"].HeaderText = "Due Date";

            dgvTasks.Columns["Id"].Visible = false; //
            dgvTasks.Columns["TaskDescription"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTasks.AllowUserToAddRows = false;

            // Add Action Buttons
            if (!dgvTasks.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.Name = "btnEdit";
                editBtn.HeaderText = "Edit";
                editBtn.Text = "Edit";
                editBtn.UseColumnTextForButtonValue = true;
                dgvTasks.Columns.Add(editBtn);

                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "btnDelete";
                deleteBtn.HeaderText = "Action";
                deleteBtn.Text = "X";
                deleteBtn.UseColumnTextForButtonValue = true;
                dgvTasks.Columns.Add(deleteBtn);
            }
        }

        private void UpdateCounts()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmdDone = new SqlCommand("SELECT COUNT(*) FROM Tasks WHERE IsCompleted = 1", conn);
                    int doneCount = (int)cmdDone.ExecuteScalar();

                    SqlCommand cmdPending = new SqlCommand("SELECT COUNT(*) FROM Tasks WHERE IsCompleted = 0", conn);
                    int pendingCount = (int)cmdPending.ExecuteScalar();

                    // UI Update
                    lblCompleted.Text = $"Completed: {doneCount}";
                    lblPending.Text = $"Pending: {pendingCount}";
                }
                catch (Exception) { /* If labels are missing, this prevents a crash */ }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTaskName.Text))
            {
                MessageBox.Show("Please enter a task description.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    string query = (selectedTaskId == -1)
                        ? "INSERT INTO Tasks (TaskDescription, DueDate, IsCompleted) VALUES (@desc, @date, @status)"
                        : "UPDATE Tasks SET TaskDescription = @desc, DueDate = @date WHERE Id = @id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@desc", txtTaskName.Text);
                    cmd.Parameters.AddWithValue("@date", dtpDueDate.Value);

                    if (selectedTaskId == -1)
                        cmd.Parameters.AddWithValue("@status", 0);
                    else
                        cmd.Parameters.AddWithValue("@id", selectedTaskId);

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    // Reset UI
                    txtTaskName.Clear();
                    btnAddTask.Text = "Add Task";
                    selectedTaskId = -1;
                    LoadTasks();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Handle DELETE
            if (dgvTasks.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int taskId = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["Id"].Value);
                if (MessageBox.Show("Delete this task?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteTask(taskId);
                }
            }
            // Handle EDIT
            else if (dgvTasks.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                selectedTaskId = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["Id"].Value);
                txtTaskName.Text = dgvTasks.Rows[e.RowIndex].Cells["TaskDescription"].Value.ToString();
                dtpDueDate.Value = Convert.ToDateTime(dgvTasks.Rows[e.RowIndex].Cells["DueDate"].Value);
                btnAddTask.Text = "Update Task";
            }
            // Handle Checkbox Toggle
            else if (dgvTasks.Columns[e.ColumnIndex].Name == "IsCompleted")
            {
                dgvTasks.EndEdit();
                int taskId = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["Id"].Value);
                bool isDone = Convert.ToBoolean(dgvTasks.Rows[e.RowIndex].Cells["IsCompleted"].Value);
                UpdateStatus(taskId, isDone);
            }
        }

        private void UpdateStatus(int id, bool status)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "UPDATE Tasks SET IsCompleted = @status WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                UpdateCounts();
            }
        }

        private void DeleteTask(int id)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Tasks WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadTasks();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 1. Clear the text field
            txtTaskName.Clear();

            // 2. Reset the date to today
            dtpDueDate.Value = DateTime.Now;

            // 3. Reset the Edit mode
            selectedTaskId = -1;
            btnAddTask.Text = "Add Task";

            // 4. (Optional) Focus back on the textbox for quick typing
            txtTaskName.Focus();
        }
    }
}