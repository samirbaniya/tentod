using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trydataviewgridsql
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection
            ("Data Source=DESKTOP-GIVARQA\\SQLEXPRESS;" +
            "Initial Catalog=dvg;" +
            "Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
            LoadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData()
        {
            try
            {
                con.Open();

                // Retrieve data from the database
                string selectQuery = "SELECT * FROM dvgt";
                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
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
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }
    }
}