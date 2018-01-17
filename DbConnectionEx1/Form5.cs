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
    public partial class Form5 : Form
    {
        string imgFileName;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //var conStr = ConfigurationManager.ConnectionStrings["mssql"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(conStr))
            //{
            //    string query = "SELECT Picture,CategoryName FROM DBO.Categories WHERE CategoryID =1";
            //    using (var cmd = new SqlCommand(query, con))
            //    {
            //        con.Open();
            //        SqlDataReader sdr = cmd.ExecuteReader();
            //        if (!sdr.HasRows)
            //        {
            //            MessageBox.Show("데 없");
            //            return;
            //        }
            //        else
            //        {
            //            byte[] cateImg = (byte[])sdr["Picture"];
            //            while (sdr.Read())
            //            {
            //                if (cateImg != null)
            //                {
            //                    MemoryStream ms = new MemoryStream();
            //                    ms.Write(cateImg, 78, cateImg.Length - 78);
            //                    pictureBox1.Image = new Bitmap(ms);
            //                    label1.Text = sdr["CategoryName"].ToString();
            //                }
            //            }
            //        }
            //        label1.Text = sdr["CateorgyName"].ToString();
            //        sdr.Close();
            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkTextBox() && checkPK())
            {
                string uName = this.textBox2.Text.Trim().Replace(" ", "");
                string uMobile = this.textBox3.Text.Trim().Replace(" ", "");
                string uAddress = this.textBox1.Text.Trim();

                //이미지 저장
                FileStream fs = new FileStream(imgFileName.ToString(),FileMode.Open,FileAccess.Read);
                byte[] bImg = new byte[fs.Length];
                fs.Read(bImg, 0, (int)fs.Length);

                #region innerQuerry주석
                //inner Query : 코드안에 쿼리문이 내장(보안성취약)

                //string query = "Insert into Friends values(N'"+uName+"','"+uMobile+"',N'"+uAddress+"');";
                ////MessageBox.Show(query);
                //using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
                //{
                //    con.Open();
                //    using (var cmd = new SqlCommand(query,con))
                //    {
                //        int i = cmd.ExecuteNonQuery();
                //        if (i == 1)
                //        {
                //            MessageBox.Show("저장이 완료되었습니다.");
                //            ComponentInit();
                //            return;
                //        }
                //        else
                //        {
                //            MessageBox.Show("저장 실풰");
                //            ComponentInit();
                //            return;
                //        }
                //    }
                //}
                #endregion

                //개선후
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
                {
                    
                    using (var cmd = new SqlCommand("SaveFriend", con))
                    {
                        //실행할 쿼리문이 저장 프로시저에 있다
                        cmd.CommandType = CommandType.StoredProcedure;

                        //저장 프로시저 실행에 필요한 파라메터를 지정
                        cmd.Parameters.AddWithValue("@uName", uName);
                        cmd.Parameters.AddWithValue("@uMobile", uMobile);
                        cmd.Parameters.AddWithValue("@uAddr", uAddress);
                        cmd.Parameters.AddWithValue("@uImg", bImg);

                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageBox.Show("저장이 완료되었습니다.");
                            ComponentInit();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("failed");
                            ComponentInit();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("데이터가 유효하지않아 저장 실패!");
                ComponentInit();
                return;
            }
        }

        private bool checkPK()
        {
            string uMobile = this.textBox3.Text.Trim().Replace(" ", "");

            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["compactDb"].ConnectionString))
            {

                using (var cmd = new SqlCommand("checkPK", con))
                {
                    //실행할 쿼리문이 저장 프로시저에 있다
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uMobile", uMobile);
                    con.Open();
                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("중복되는 번호가 있습니다.");
                        ComponentInit();
                        sdr.Close();
                        con.Close();
                        return false;
                    }
                    else
                    {
                        sdr.Close();
                        con.Close();
                        return true;
                    }
                }
            }
        }

        private  bool checkTextBox()
        {
            if (this.textBox1.Text ==""|| this.textBox2.Text =="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComponentInit();
        }

        private void ComponentInit()
        {
            this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = " "; ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            imgFileName = null;
            var dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                imgFileName = openFileDialog1.FileName;
            }
        }
    }
}
