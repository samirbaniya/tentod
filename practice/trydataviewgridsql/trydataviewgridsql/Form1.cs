using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace trydataviewgridsql
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection("Data Source=DESKTOP-GIVARQA\\SQLEXPRESS;Initial Catalog=dvg;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(con.ConnectionString))
                {
                    connection.Open();

                    // Retrieve data from the database
                    string selectQuery = "SELECT * FROM dvgt";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Bind the DataTable to the DataGridView
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click events if needed
        }
    }
}

