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

namespace lab3qno1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(
            "Data Source=DESKTOP-GIVARQA\\SQLEXPRESS;" +
            "Initial Catalog=slab;" +
            "Integrated Security=True");
        SqlDataAdapter dat;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            dataGridView1.CellClick += dataGridView1_CellContentClick;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            dat = new SqlDataAdapter("Select * from s_table", con);
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            user_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            user_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            user_phone.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void create_Click(object sender, EventArgs e)
        {
            if (user_id.Text != "" && user_name.Text != "" && user_phone.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("Insert into s_table values(@id, @name, @phone)", con);
                cmd.Parameters.AddWithValue("@id", user_id.Text.ToString());
                cmd.Parameters.AddWithValue("@name", user_name.Text);
                cmd.Parameters.AddWithValue("@phone", user_phone.Text.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
                DataTable dt = new DataTable();
                dat.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                user_id.Text = "";
                user_name.Text = "";
                user_phone.Text = "";
            }
            else
            {
                MessageBox.Show("Can't leave empty textbox");
            }

        }

        private void update_Click(object sender, EventArgs e)
        {
            if (user_name.Text != "" && user_phone.Text != "")
            {
                con.Open();
                cmd = new SqlCommand("UPDATE s_table SET UserName = @name, [Phone No] = @phone WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", user_id.Text.ToString());
                cmd.Parameters.AddWithValue("@name", user_name.Text);
                cmd.Parameters.AddWithValue("@phone", user_phone.Text.ToString());
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data updated successfully");
                }
                else
                {
                    MessageBox.Show("Error updating data");
                }
                DataTable dt = new DataTable();
                dat.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                user_id.Text = "";
                user_name.Text = "";
                user_phone.Text = "";
            }
            else
            {
                MessageBox.Show("Can't leave empty textbox");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            con.Open();

            // Use parameterized query to delete by name
            cmd = new SqlCommand("DELETE FROM s_table WHERE Id = @Id", con);

            // Add parameter
            cmd.Parameters.AddWithValue("@Id", user_id.Text);
            
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Record deleted successfully!");
            }
            else
            {
                MessageBox.Show("Error deleting data");
            }
            

            DataTable dt = new DataTable();
            dat.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void user_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

