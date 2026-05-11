using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProductForm
{
    public partial class Form2 : Form
    {
        private DataTable productsTable; 

        public Form2()
        {
            InitializeComponent();
            LoadProducts(); 
            this.Shown += Form2_Shown; 
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
                    dataGridView1.DataSource = productsTable;
                }
            }
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            LoadProducts(); 
        }

        private void comboHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = comboHistory.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Product":
                    Form1 availableProductsForm = new Form1();
                    availableProductsForm.Show();
                    this.Hide();
                    break;

                case "Stock IN":
                    Form3 stockInForm = new Form3();
                    stockInForm.Show();
                    this.Hide();
                    break;

                case "Stock OUT":
                    Form4 stockOutForm = new Form4();
                    stockOutForm.Show();
                    this.Hide();
                    break;

                case "Product History":
                    Form5 productHistoryForm = new Form5();
                    productHistoryForm.Show();
                    this.Hide();
                    break;

                default:
                    break;
            }
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            Form3 stockInForm = new Form3();
            stockInForm.Show();
            this.Hide();
        }

        private void btnsout_Click(object sender, EventArgs e)
        {
            Form4 stockOutForm = new Form4();
            stockOutForm.Show();
            this.Hide();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void txtsearch1_TextChanged(object sender, EventArgs e)
        {
            if (productsTable != null)
            {
                string filterText = txtsearch1.Text.Trim();

                string filterExpression = $"Product_ID LIKE '%{filterText}%' " +
                                          $"OR Product_Name LIKE '%{filterText}%' " +
                                          $"OR Product_Description LIKE '%{filterText}%' " +
                                          $"OR Unit LIKE '%{filterText}%'";

                if (int.TryParse(filterText, out int numericFilter))
                {
                    filterExpression += $" OR Quantity = {numericFilter}";
                }
                DataView dv = productsTable.DefaultView;
                dv.RowFilter = filterExpression;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}