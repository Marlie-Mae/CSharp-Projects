using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace ProductForm
{
    public partial class Form5 : Form
    {
        private DataTable combinedTable; // To hold the combined data for display

        public Form5()
        {
            InitializeComponent();
            LoadHistoryData(); // Load the history data on form initialization
        }

        private void LoadHistoryData()
        {
            string connectionString = @"Data Source=DESKTOP-TI7OG5Q\SQLEXPRESS;Initial Catalog=ProductDB;Integrated Security=True;TrustServerCertificate=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"
                    SELECT 
                        h.History_ID,
                        h.Product_ID,
                        p.Product_Name,
                        h.Transaction_Date,
                        h.Transaction_Type,
                        h.Quantity,
                        h.Unit,
                        h.Supplier,
                        h.Customer
                    FROM 
                        History h
                    JOIN 
                        Products p ON h.Product_ID = p.Product_ID";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    combinedTable = new DataTable();
                    adapter.Fill(combinedTable);
                }
            }

            // Bind the combined data to the DataGridView
            dataGridView1.DataSource = combinedTable;

            // Optionally set column headers or format the DataGridView
            dataGridView1.Columns["History_ID"].HeaderText = "History ID";
            dataGridView1.Columns["Product_ID"].HeaderText = "Product ID";
            dataGridView1.Columns["Product_Name"].HeaderText = "Product Name";
            dataGridView1.Columns["Transaction_Date"].HeaderText = "Transaction Date";
            dataGridView1.Columns["Transaction_Type"].HeaderText = "Transaction Type";
            dataGridView1.Columns["Quantity"].HeaderText = "Quantity";
            dataGridView1.Columns["Unit"].HeaderText = "Unit";
            dataGridView1.Columns["Supplier"].HeaderText = "Supplier";
            dataGridView1.Columns["Customer"].HeaderText = "Customer";
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            // Check if combinedTable has data to filter
            if (combinedTable != null)
            {
                string filterText = txtsearch.Text.Trim();

                // Set up filter across multiple columns (Product_ID, Product_Name, Supplier, Customer, Transaction_Type, Transaction_Date, Quantity, Unit)
                string filterExpression = $"Product_ID LIKE '%{filterText}%' " +
                                          $"OR Product_Name LIKE '%{filterText}%' " +
                                          $"OR Supplier LIKE '%{filterText}%' " +
                                          $"OR Customer LIKE '%{filterText}%' " +
                                          $"OR Transaction_Type LIKE '%{filterText}%' " +
                                          $"OR CONVERT(Transaction_Date, 'System.String') LIKE '%{filterText}%' " +
                                          $"OR Unit LIKE '%{filterText}%'";

                // If filterText can be parsed as an integer, add Quantity filter
                if (int.TryParse(filterText, out int numericFilter))
                {
                    filterExpression += $" OR Quantity = {numericFilter}";
                }

                // Apply filter to the DataView
                DataView dv = combinedTable.DefaultView;
                dv.RowFilter = filterExpression;
            }
        }



        private void comboHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboHistory.SelectedItem.ToString())
            {
                case "Product":
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                    break;
                case "Available Products":
                    Form2 form2 = new Form2();
                    form2.Show();
                    this.Hide();
                    break;
                case "Stock IN":
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                    break;
                case "Stock OUT":
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide();
                    break;
                default:
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell clicks if you need specific functionality
        }

        private void btnexit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
