using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject0._1
{
   
    public partial class frmEmp : Form
    {
        public class Connector
        {
            SqlConnection con;

            private void initConnection()
            {
                if (con == null)
                {
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["root"].ConnectionString);
                    con.Open();
                }
            }

            public SqlConnection getInstance()
            {
                if (con == null)
                {
                    initConnection();
                }

                return con;
            }
        }
        public frmEmp()
        {
            InitializeComponent();
        }
        string Img = null;
     
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                Img = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(Img);

            }
        }

        

    
    private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmp() && EmpId())
            {
                int empId = int.Parse(tboxENum.Text);//직원번호
                string empName = tboxEname.Text.Trim().Replace(" ", "");//직원명
                int empPass = int.Parse(mboxPass.Text);//직원 비번
                int empWork = int.Parse(cboxdate.Text);//근무시간
                string phone = mtboxTel.Text;//전화
                int empRank = int.Parse(cboxDept.Text);//직급
                DateTime hiredate = DateTime.Parse(dateTimePicker1.Text);//입사일
             
                
                    //입력하게함 
                    FileStream fs = new FileStream(Img.ToString(), FileMode.Open, FileAccess.Read);
                    byte[] bImg = new byte[fs.Length];
                    fs.Read(bImg, 0, (int)fs.Length);
                    using (var con = new Connector().getInstance())
                    {

                        using (var cmd = new SqlCommand("SaveEmployee", con))
                        {
                            //실행할 쿼리문이 저장프로시저에 있다.
                            cmd.CommandType = CommandType.StoredProcedure;
                            //저장프로시저 실행에 필요한 파라메터를 지정
                            cmd.Parameters.AddWithValue("@EmpId", empId);
                            cmd.Parameters.AddWithValue("@EmpName", empName);
                            cmd.Parameters.AddWithValue("@EmpPwd", empPass);
                            cmd.Parameters.AddWithValue("@Empimg", bImg);
                            cmd.Parameters.AddWithValue("@WorkTime", empWork);
                            cmd.Parameters.AddWithValue("@phone", phone);
                            cmd.Parameters.AddWithValue("@rankNum", empRank);
                            cmd.Parameters.AddWithValue("@hiredate", hiredate);
                       
                            int i = cmd.ExecuteNonQuery();//insert문 1=저장 0=저장 안됨
                            if (i == 1)
                            {
                                //MessageBox.Show("저장");
                                Empty();
                                return;
                            }
                            else
                            {
                                //MessageBox.Show("저장 안됨");
                                Empty();
                                return;
                            }
                        }

                    }
            }
            else
            {
                MessageBox.Show("데이터가 유효하지 않아 저장 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
                return;
            }
        }//직원추가
        private bool EmpId()
        {
            string empId = tboxENum.Text;
            using (var con = new Connector().getInstance())
            {

                using (var cmd = new SqlCommand("CheckEmp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                   
                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        MessageBox.Show("중복되는 사원이 있습니다.");
                        Empty();
                        sdr.Close();
                        con.Close();
                        return false;
                    }
                    else
                    {
                        sdr.Close();
                        return true;

                    }

                }
            }
        }
        private bool CheckEmp()
        {
            if (tboxEname.Text ==""|| tboxENum.Text==""|| mtboxTel.Text==""||cboxDept.Text==""||cboxdate.Text==""||dateTimePicker1.Text=="")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void Empty()
        {
            pictureBox1.Image = null;
            tboxEname.Text = mboxPass.Text = tboxENum.Text = mtboxTel.Text = cboxDept.Text = cboxdate.Text = dateTimePicker1.Text = "";
          
            tboxEname.Focus();
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Empty();
        }
        private void frmEmp_Load(object sender, EventArgs e)
        {
            cboxDept.Items.Add(1);//사장
            cboxDept.Items.Add(2);//매니저
            cboxDept.Items.Add(3);//알바

            cboxdate.Items.Add(1);
            cboxdate.Items.Add(2);
            cboxdate.Items.Add(3);
            cboxdate.Items.Add(4);
            cboxdate.Items.Add(5);
            cboxdate.Items.Add(6);
        }
    }
}
