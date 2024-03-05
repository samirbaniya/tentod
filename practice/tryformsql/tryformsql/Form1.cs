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

namespace tryformsql
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GIVARQA\\SQLEXPRESS;Initial Catalog=testsql;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("insert into testfirst(name,address)values('" + textBox1.Text+"','"+textBox2.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Data saved");
            }
            else
            {
                MessageBox.Show("error");
            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Use parameterized query to delete by name
                string deleteQuery = "DELETE FROM testfirst WHERE name = @Name AND address = @Address";
                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    // Add parameter
                    cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Address", textBox2.Text);


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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
