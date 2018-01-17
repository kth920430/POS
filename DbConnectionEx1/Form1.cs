using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbConnectionEx1
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gd3-3\source\repos\DbConnectionEx1\DbConnectionEx1\Friends.mdf;Integrated Security=True";

            con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                MessageBox.Show("연결 성공!");
                this.textBox1.Text = "DataBase : " + con.Database + "\r\n";
                this.textBox1.Text += "DataSource : " + con.DataSource + "\r\n";
                this.textBox1.Text += "DataServerVersion : " + con.ServerVersion + "\r\n";
                this.textBox1.Text += "State : " + con.State + "\r\n";
                this.textBox1.Text += "WorkStation ID : " + con.WorkstationId + "\r\n";
            }
            catch (Exception)
            {

                MessageBox.Show("연결 실패");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Close();
            MessageBox.Show("연결 종료");
            this.textBox1.Text = "State : " + con.State;
            //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form6().Show();
        }
    }
}
