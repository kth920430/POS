using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string querys = "SELECT * FROM Categories";

            //string connectString = "Server=192.168.3.19,1433;Database=Northwind;User Id=sa;Password =1111;";
            //SqlConnection con = new SqlConnection(connectString);
            //App.config에서 mssql을 Add후 아래처럼 바꿀경우 아이디 비밀번호 유출을 피할 수 있다.
            var conStr = ConfigurationManager.ConnectionStrings["mssql"].ConnectionString;
            SqlConnection con = new SqlConnection(conStr);

            con.Open();

            SqlCommand cmd = new SqlCommand(querys,con);
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                this.textBox1.Text += "CategoryID : " + sdr.GetInt32(0) + "\r\n";
                this.textBox1.Text += "CategoryName : " + sdr.GetString(1) + "\r\n";
                this.textBox1.Text += "Description : " + sdr.GetString(2) + "\r\n";
                this.textBox1.Text += "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\r\n";
            }
            sdr.Close();
            con.Close();
        }
    }
}
