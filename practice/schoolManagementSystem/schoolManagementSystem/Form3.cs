using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Refresh();

            // Create an ArrayList and populate it with some data
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Person("John", 25));
            arrayList.Add(new Person("Alice", 30));
            arrayList.Add(new Person("Bob", 28));

            // Set the ArrayList as the DataSource of the DataGridView
            dataGridView1.DataSource = arrayList;

            // Optionally, configure DataGridView columns
            dataGridView1.AutoGenerateColumns = true; // Automatically generate columns based on the data source
            dataGridView1.Columns[1].HeaderText = "Name"; // Customize column header text
            dataGridView1.Columns[2].HeaderText = "Age";
        }
    } // Sample class representing a person
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
