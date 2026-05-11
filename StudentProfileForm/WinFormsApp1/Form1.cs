using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Phil\Documents\testing.mdf;Integrated Security=True;Connect Timeout=30");
        private string? selectedStudentId = null;

        public Form1()
        {
            InitializeComponent();
            LoadData();

            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
            comboBox1.Items.Add("Other");

            textBox4.Text = "Auto-generated ID"; 
            textBox4.ForeColor = SystemColors.GrayText; // Placeholder color

            // Subscribe to the TextChanged event for search functionality
            textBox5.TextChanged += TextBox5_TextChanged;

            // Handle the focus event to clear the placeholder
            textBox4.GotFocus += TextBox4_GotFocus;
            textBox4.LostFocus += TextBox4_LostFocus;
        }

        private void TextBox4_GotFocus(object sender, EventArgs e)
        {
            if (textBox4.Text == "Auto-generated ID")
            {
                textBox4.Text = "";
                textBox4.ForeColor = SystemColors.WindowText; // Default text color
            }
        }

        private void TextBox4_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox4.Text))
            {
                textBox4.Text = "Auto-generated ID"; // Placeholder text
                textBox4.ForeColor = SystemColors.GrayText; // Placeholder color
            }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            // Call the search function whenever the text changes
            SearchRecords();
        }

        private void button1_Click(object sender, EventArgs e) // Add button
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                // Use textBox4's value if it is not the placeholder
                string studentId = textBox4.Text.Trim() == "Auto-generated ID" ? null : textBox4.Text;

                SqlCommand cmdGetMaxId = new SqlCommand("SELECT MAX(StudentID) FROM [dbo].[Table]", con);
                var maxIdResult = cmdGetMaxId.ExecuteScalar();
                string newStudentId;

                if (maxIdResult != DBNull.Value)
                {
                    string maxId = maxIdResult.ToString();
                    int nextIdNum = int.Parse(maxId.Substring(1)) + 1;
                    newStudentId = "S" + nextIdNum.ToString("D3");
                }
                else
                {
                    newStudentId = "S001";
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO [dbo].[Table] (StudentID, FirstName, LastName, PhoneNumber, Address, Gender) VALUES (@id, @value1, @value2, @value3, @value4, @value5)";

                cmd.Parameters.AddWithValue("@id", studentId ?? newStudentId); // Use user-entered ID or generate a new one
                cmd.Parameters.AddWithValue("@value1", textBox2.Text); // FirstName
                cmd.Parameters.AddWithValue("@value2", textBox1.Text); // LastName
                cmd.Parameters.AddWithValue("@value3", textBox3.Text); // PhoneNumber
                cmd.Parameters.AddWithValue("@value4", textBox6.Text); // Address
                cmd.Parameters.AddWithValue("@value5", comboBox1.SelectedItem?.ToString() ?? "");

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record added successfully!");
                ClearFields();
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Delete button
        {
            if (selectedStudentId == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "DELETE FROM [dbo].[Table] WHERE StudentID = @id";
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record deleted successfully!");

                // Clear the fields after deletion
                ClearFields();

                // Reload the data after deletion
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            } 
        }

        private void button3_Click(object sender, EventArgs e) // Update button
        {
            if (selectedStudentId == null)
            {
                MessageBox.Show("Please select a record to edit.");
                return;
            }

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE [dbo].[Table] SET FirstName = @value1, LastName = @value2, PhoneNumber = @value3, Address = @value4, Gender = @value5 WHERE StudentID = @id";

                cmd.Parameters.AddWithValue("@value1", textBox2.Text); // FirstName
                cmd.Parameters.AddWithValue("@value2", textBox1.Text); // LastName
                cmd.Parameters.AddWithValue("@value3", textBox3.Text); // PhoneNumber
                cmd.Parameters.AddWithValue("@value4", textBox6.Text); // Address
                cmd.Parameters.AddWithValue("@value5", comboBox1.SelectedItem?.ToString() ?? "");
                cmd.Parameters.AddWithValue("@id", selectedStudentId);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated successfully!");
                LoadData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void LoadData()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                SqlDataAdapter da = new SqlDataAdapter("SELECT StudentID, FirstName, LastName, PhoneNumber, Address, Gender FROM [dbo].[Table]", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // To show the database table
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate textboxes and combobox with the values from the clicked row
                textBox2.Text = row.Cells["FirstName"].Value?.ToString() ?? string.Empty; // FirstName
                textBox1.Text = row.Cells["LastName"].Value?.ToString() ?? string.Empty; // LastName
                textBox3.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? string.Empty; // PhoneNumber
                textBox6.Text = row.Cells["Address"].Value?.ToString() ?? string.Empty; // Address
                comboBox1.SelectedItem = row.Cells["Gender"].Value?.ToString() ?? string.Empty; // Gender

                // Store selected StudentID for updating and deleting
                selectedStudentId = row.Cells["StudentID"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox6.Clear();
            comboBox1.SelectedIndex = -1;
            textBox4.Text = "Auto-generated ID"; // Reset placeholder
            textBox4.ForeColor = SystemColors.GrayText; // Placeholder color
            selectedStudentId = null; // Reset selected ID
        }

        private void button4_Click(object sender, EventArgs e) // Clear button
        {
            ClearFields();
        }

        private void button5_Click(object sender, EventArgs e) // Search button
        {
            // Call the search function when the search button is clicked
            SearchRecords();
        }

        private void SearchRecords()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }

                string searchTerm = textBox5.Text;
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT StudentID, FirstName, LastName, PhoneNumber, Address, Gender " +
                    "FROM [dbo].[Table] " +
                    "WHERE FirstName LIKE @search OR LastName LIKE @search " +
                    "OR PhoneNumber LIKE @search OR Address LIKE @search " +
                    "OR Gender LIKE @search OR StudentID LIKE @search", con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Use BeginInvoke to set focus on the FirstName text box when the form loads
            this.BeginInvoke((MethodInvoker)delegate {
                textBox2.Focus();
            });
        }
    }
}
