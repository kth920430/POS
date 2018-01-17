using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbConnectionEx1
{
    public partial class Form4 : Form
    {
        List<friend> list = new List<friend>();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string findFriend = textBox1.Text.Trim().Replace(" ", "");//공백제거
            

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                con.Open();
                string query = "SELECT * From Friends WHERE Name like N'%" + findFriend + "%'";
                using (var cmd = new SqlCommand(query,con))
                {
                   
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("친구가 없습니다.");
                        return;
                    }
                    else
                    {                        
                        while (sdr.Read())
                        {
                            list.Add(new friend(sdr.GetString(0), sdr.GetString(1), sdr.GetString(2)));
                        }
                        dataGridView1.DataSource = list;
                        sdr.Close();
                    }
                    
                }
            }
           
            

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            this.label2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            this.label3.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            //this.pictureBox1 = byte[] 
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {
                using (var cmd = new SqlCommand("returnImg", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userMobile", this.label2.Text);
                    con.Open();
                    var sdr = cmd.ExecuteReader();
                    byte[] img = null;
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            if (sdr["FImg"] != null)
                            {
                                try
                                {
                                    img = (byte[])sdr["FImg"];
                                    pictureBox1.Image = new Bitmap(new MemoryStream(img));
                                }
                                catch (Exception)
                                {

                                    pictureBox1.Image = null;
                                }

                            }


                        }

                    }
                    else
                    {
                        return;
                    }
                    sdr.Close();
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
