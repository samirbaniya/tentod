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
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GIVARQA\\SQLEXPRESS;Initial Catalog=slab;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            con.Open();


            con.Close();

        }

        private void update_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {

        }

        private void user_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
