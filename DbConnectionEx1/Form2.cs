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

namespace DbConnectionEx1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string query = "select * from Friends";
            string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gd3-3\source\repos\DbConnectionEx1\DbConnectionEx1\Friends.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);

            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                this.textBox1.Text += "이름 : " + sdr.GetString(0) + "\r\n";
                this.textBox1.Text += "전화번호 : " + sdr.GetString(1) + "\r\n";
                this.textBox1.Text += "주소 : " + sdr.GetString(2) + "\r\n";
                this.textBox1.Text += "----------------------------------\r\n";
            }
            
        }
    }
}
