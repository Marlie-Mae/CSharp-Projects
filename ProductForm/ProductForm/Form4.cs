using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProductForm
{
    public partial class Form4 : Form
    {
        private DataTable productsTable;
        private int currentIndex = -1;

        public Form4()
        {
            InitializeComponent();
            LoadProducts();
            InitializeUnitComboBox();
        }

        private void LoadProducts()
        {
            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Products";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    productsTable = new DataTable();
                    adapter.Fill(productsTable);
                }
            }

            if (productsTable.Rows.Count > 0)
            {
                currentIndex = 0;
                LoadProductDetails();
            }
            else
            {
                MessageBox.Show("No products available.");
            }
        }

        private void InitializeUnitComboBox()
        {
            comboUnit1.Items.AddRange(new string[] { "pcs", "kg", "ltr", "box", "dozen", "gram", "meter", "pack" });
        }

        private void LoadProductDetails()
        {
            if (currentIndex >= 0 && currentIndex < productsTable.Rows.Count)
            {
                DataRow row = productsTable.Rows[currentIndex];
                txtpid1.Text = row["Product_ID"].ToString();
                txtpname1.Text = row["Product_Name"].ToString();
                quantity1.Value = row["Quantity"] != DBNull.Value ? Convert.ToInt32(row["Quantity"]) : 0;
                comboUnit1.SelectedItem = row["Unit"] != DBNull.Value ? row["Unit"].ToString() : null;
            }
        }

        private void btnnext1_Click(object sender, EventArgs e)
        {
            if (currentIndex < productsTable.Rows.Count - 1)
            {
                currentIndex++;
                LoadProductDetails();
            }
            else
            {
                MessageBox.Show("You are at the last product.");
            }
        }

        private void btnprev1_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                LoadProductDetails();
            }
            else
            {
                MessageBox.Show("You are at the first product.");
            }
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";
            string productId = txtpid1.Text;
            string customer = txtcustomer.Text;
            int quantityRemoved = (int)quantity1.Value;
            DateTime transactionDate = dateTimePicker1.Value;
            string unit = comboUnit1.SelectedItem?.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Insert into History table
                    string insertQuery = @"INSERT INTO History (Product_ID, Transaction_Date, Transaction_Type, Quantity, Unit, Supplier, Customer) 
                                           VALUES (@ProductID, @TransactionDate, 'Out', @Quantity, @Unit, '', @Customer)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@TransactionDate", transactionDate);
                        command.Parameters.AddWithValue("@Quantity", quantityRemoved);
                        command.Parameters.AddWithValue("@Unit", unit);
                        command.Parameters.AddWithValue("@Customer", customer);
                        command.ExecuteNonQuery();
                    }

                    // Update Quantity in Products table (deducting stock)
                    string updateProductQuery = @"UPDATE Products SET Quantity = Quantity - @Quantity WHERE Product_ID = @ProductID AND Quantity >= @Quantity";
                    using (SqlCommand updateCommand = new SqlCommand(updateProductQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@ProductID", productId);
                        updateCommand.Parameters.AddWithValue("@Quantity", quantityRemoved);

                        int rowsAffected = updateCommand.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("Insufficient stock for this product.");
                            transaction.Rollback();
                            return;
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Stock OUT transaction recorded successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error in recording transaction: " + ex.Message);
                }
            }
        }

        private void btnclear1_Click(object sender, EventArgs e)
        {
            txtpid1.Clear();
            txtpname1.Clear();
            quantity1.Value = 0;
            comboUnit1.SelectedIndex = -1;
            txtcustomer.Clear();
        }

        private void btnprod1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnavail1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnhistory1_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}