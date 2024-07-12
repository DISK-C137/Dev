using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyDataHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myDataHubDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.myDataHubDataSet.Users);
            // กำหนด Connection String ของฐานข้อมูล
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=MyDataHub;Integrated Security=True";

            // สร้าง SqlConnection และ SqlDataAdapter
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", connection);

            // สร้าง DataTable สำหรับเก็บข้อมูล
            DataTable dataTable = new DataTable();

            // เติมข้อมูลใน DataTable จาก SqlDataAdapter
            adapter.Fill(dataTable);

            // กำหนด DataSource ของ DataGridView เป็น DataTable
            dataGridView1.DataSource = dataTable;
        }
    }
}
