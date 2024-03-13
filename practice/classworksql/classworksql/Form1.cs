using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace classworksql
{
    public partial class Form1 : Form
    {
        private readonly string connectionString = "Data Source=DESKTOP-GIVARQA\\SQLEXPRESS;Initial Catalog=cw;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve data from the database
                    string selectQuery = "SELECT * FROM cwt";
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

        private void create_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string insertQuery = "INSERT INTO cwt(User_id, UserName, Phone) VALUES(@Id, @Name, @Phone)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", user_id.Text);
                        cmd.Parameters.AddWithValue("@Name", user_name.Text);
                        cmd.Parameters.AddWithValue("@Phone", user_phone.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data saved");
                        }
                        else
                        {
                            MessageBox.Show("Error saving data");
                        }
                    }
                    // Refresh data in the DataGridView
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                user_id.Clear();
                user_name.Clear();
                user_phone.Clear();
            }
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Use parameterized query to delete by name
                    string deleteQuery = "DELETE FROM cwt WHERE User_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                    {
                        // Add parameter
                        cmd.Parameters.AddWithValue("@Id", user_id.Text);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No matching records found for deletion.");
                        }
                    }
                    // Refresh data in the DataGridView
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                user_id.Clear();
            }
        }

        private void update_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string updateQuery = "UPDATE cwt SET UserName = @Name, Phone = @Phone WHERE User_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", user_name.Text);
                        cmd.Parameters.AddWithValue("@Phone", user_phone.Text);
                        cmd.Parameters.AddWithValue("@Id", user_id.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data updated successfully");
                        }
                        else
                        {
                            MessageBox.Show("Error updating data");
                        }
                    }
                    // Refresh data in the DataGridView
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                user_id.Clear();
                user_name.Clear();
                user_phone.Clear();
            }
        }

        private void select_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Retrieve data from the database based on User_id
                    string selectQuery = "SELECT * FROM cwt WHERE User_id = @Id";
                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", user_id.Text);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Check if any data is retrieved
                            if (dataTable.Rows.Count > 0)
                            {
                                // Bind the DataTable to the DataGridView
                                dataGridView1.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No matching records found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting data: {ex.Message}");
            }
        }
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate TextBoxes with selected values
                user_id.Text = row.Cells["User_id"].Value.ToString();
                user_name.Text = row.Cells["UserName"].Value.ToString();
                user_phone.Text = row.Cells["Phone"].Value.ToString();

            }
        }

    }
}
