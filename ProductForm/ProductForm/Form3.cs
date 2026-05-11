using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProductForm
{
    public partial class Form3 : Form
    {
        private DataTable productsTable; 
        private int currentIndex = -1;

        public Form3()
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
                string query = @"
                    SELECT p.Product_ID, p.Product_Name, p.Quantity, p.Unit
                    FROM Products p";
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
            comboUnit.Items.AddRange(new string[] { "pcs", "kg", "ltr", "box", "dozen", "gram", "meter", "pack" });
        }

        private void LoadProductDetails()
        {
            if (currentIndex >= 0 && currentIndex < productsTable.Rows.Count)
            {
                DataRow row = productsTable.Rows[currentIndex];
                txtpid.Text = row["Product_ID"].ToString();
                txtpname.Text = row["Product_Name"].ToString();

                if (row["Quantity"] != DBNull.Value)
                {
                    quantity.Value = Convert.ToInt32(row["Quantity"]);
                }
                else
                {
                    quantity.Value = 0;
                }

                if (row["Unit"] != DBNull.Value)
                {
                    comboUnit.SelectedItem = row["Unit"].ToString();
                }
                else
                {
                    comboUnit.SelectedIndex = -1; 
                }

                LoadSupplierForProduct(row["Product_ID"].ToString());
            }
        }

        private void LoadSupplierForProduct(string productId)
        {
            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TOP 1 Supplier FROM History WHERE Product_ID = @ProductID ORDER BY Transaction_Date DESC"; 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", productId);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        txtsupplier.Text = result.ToString();
                    }
                    else
                    {
                        txtsupplier.Clear();
                    }
                }
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
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

        private void btnprev_Click(object sender, EventArgs e)
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            string productId = txtpid.Text;
            string supplier = txtsupplier.Text;
            string customer = " "; 
            int quantityAdded = (int)quantity.Value;
            DateTime transactionDate = dateTimePicker1.Value;
            string unit = comboUnit.SelectedItem?.ToString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string insertQuery = @"INSERT INTO History (Product_ID, Transaction_Date, Transaction_Type, Quantity, Unit, Supplier, Customer) 
                                   VALUES (@ProductID, @TransactionDate, 'In', @Quantity, @Unit, @Supplier, @Customer)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@ProductID", productId);
                        command.Parameters.AddWithValue("@TransactionDate", transactionDate);
                        command.Parameters.AddWithValue("@Quantity", quantityAdded);
                        command.Parameters.AddWithValue("@Unit", unit);
                        command.Parameters.AddWithValue("@Supplier", supplier);
                        command.Parameters.AddWithValue("@Customer", customer);
                        command.ExecuteNonQuery();
                    }

                    string updateProductQuery = @"UPDATE Products 
                                          SET Quantity = COALESCE(Quantity, 0) + @Quantity, Unit = @Unit 
                                          WHERE Product_ID = @ProductID";
                    using (SqlCommand updateCommand = new SqlCommand(updateProductQuery, connection, transaction))
                    {
                        updateCommand.Parameters.AddWithValue("@ProductID", productId);
                        updateCommand.Parameters.AddWithValue("@Quantity", quantityAdded);
                        updateCommand.Parameters.AddWithValue("@Unit", unit);
                        updateCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Stock IN transaction recorded successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error in recording transaction: " + ex.Message);
                }
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpid.Clear();
            txtpname.Clear();
            quantity.Value = 0;
            comboUnit.SelectedIndex = -1; 
            txtsupplier.Clear();
        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnavail_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); 
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide(); 
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}