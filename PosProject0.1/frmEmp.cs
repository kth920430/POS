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
        List<Employee> list = new List<Employee>();

        public class Connector
        {
            SqlConnection con;

            private void initConnection()
            {
                if (con == null)
                {
                    con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString);
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
        }//직원 아이디 중복
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
        private void SelectEmployee()
        {
            tboxENum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tboxEname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mboxPass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtboxTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cboxdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cboxDept.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
        private void Resets()
        {
            dataGridView1.DataSource = null;
            list.Clear();
            EmpLoad();
            dataGridView1.DataSource = list;
            dataGridView1.Refresh();
        }
        private void EmpLoad()
        {
            using (var con = new Connector().getInstance())
            {

                using (var cmd = new SqlCommand("EmployeesLoad", con))
                {
                    var sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        list.Add(new Employee()
                        {
                            EmpId = int.Parse(sdr.GetInt32(0).ToString()),
                            EmpName = sdr.GetString(1).ToString(),
                            EmpPass = int.Parse(sdr.GetInt32(2).ToString()),
                            WorkTime = int.Parse(sdr.GetInt32(4).ToString()),
                            Phone = sdr.GetString(5).ToString(),
                            Hiredate = DateTime.Parse(sdr.GetDateTime(6).ToString()),
                            Rank = int.Parse(sdr.GetInt32(7).ToString())
                        });
                    }
                    dataGridView1.DataSource = list;
                    sdr.Close();
                }

            }
        }
        private void EmpAdd(int empId, string empName, int empPass, int empWork, string phone, int empRank, DateTime hiredate, byte[] bImg, SqlCommand cmd)
        {
            //실행할 쿼리문이 저장프로시저에 있다.
            cmd.CommandType = CommandType.StoredProcedure;
            //저장프로시저 실행에 필요한 파라메터를 지정
            cmd.Parameters.AddWithValue("@EmpId", empId);
            cmd.Parameters.AddWithValue("@EmpName", empName);
            cmd.Parameters.AddWithValue("@EmpPwd", empPass);
            cmd.Parameters.AddWithValue("@EmpImg", bImg);
            cmd.Parameters.AddWithValue("@WorkTime", empWork);
            cmd.Parameters.AddWithValue("@Phone", phone);
            cmd.Parameters.AddWithValue("@RankNum", empRank);
            cmd.Parameters.AddWithValue("@Hiredate", hiredate);

            int i = cmd.ExecuteNonQuery();//insert문 1=저장 0=저장 안됨
            if (i == 1)
            {
                //MessageBox.Show("저장");
                Resets();
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
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                Img = openFileDialog1.FileName;
                pictureBox1.Image = new Bitmap(Img);

            }
        }//사진선택

        
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Empty();
        }//취소

        private void frmEmp_Load(object sender, EventArgs e)
        {
            cboxDept.Items.Add(1);//사장
            cboxDept.Items.Add(2);//매니저
            cboxDept.Items.Add(3);//알바
            cboxdate.Items.Add(0);
            EmpLoad();
        }//폼로드

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            SelectEmployee();
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("EmpImg", con))
                {

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpName", tboxEname.Text);
               
                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            if (sdr["EmpImg"] != null)
                            {
                                try
                                {
                                    byte[] img = (byte[])sdr["EmpImg"];
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
                }

            }
        }//클릭시 데이터 나타남

        private void btnReset_Click(object sender, EventArgs e)
        {
            Resets();
        }//새로고침 
        
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
                                 EmpAdd(empId, empName, empPass, empWork, phone, empRank, hiredate, bImg, cmd);
                                    return;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {

                using (var cmd = new SqlCommand("EmpDelete", con))
                {
                    //실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;
                    //저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@EmpId", tboxENum.Text);
          

                    int i = cmd.ExecuteNonQuery();//insert문 1=저장 0=저장 안됨
                    if (i == 1)
                    {
                        //MessageBox.Show("저장");

                        Resets();
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
        }//직원삭제

        private void btnModified_Click(object sender, EventArgs e)
        {
                int empId = int.Parse(tboxENum.Text);//직원번호
                string empName = tboxEname.Text.Trim().Replace(" ", "");//직원명
                int empPass = int.Parse(mboxPass.Text);//직원 비번
                int empWork = int.Parse(cboxdate.Text);//근무시간
                string phone = mtboxTel.Text;//전화
                int empRank = int.Parse(cboxDept.Text);//직급
                DateTime hiredate = DateTime.Parse(dateTimePicker1.Text);//입사일


            //입력하게함 
        
                using (var con = new Connector().getInstance())
                {
                   using (var cmd = new SqlCommand("UpdateEmp", con))
                    {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@EmpId", empId);
                    cmd.Parameters.AddWithValue("@EmpName", empName);
                    cmd.Parameters.AddWithValue("@EmpPwd", empPass);
                    cmd.Parameters.AddWithValue("@WorkTime", empWork);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@RankNum", empRank);
                    cmd.Parameters.AddWithValue("@Hiredate", hiredate);

                    int i = cmd.ExecuteNonQuery();//insert문 1=저장 0=저장 안됨
                    if (i == 1)
                    {
                        //MessageBox.Show("저장");
                        Resets();
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
    
        }//직원 수정

        private void btnSerch_Click(object sender, EventArgs e)
        {
            List<Employee> emp = new List<Employee>();
            string empname = tboxSerach.Text;
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("EmpSerach", con))
                {
                   
                    //실행할 쿼리문이 저장프로시저에 있다.
                    cmd.CommandType = CommandType.StoredProcedure;
                    //저장프로시저 실행에 필요한 파라메터를 지정
                    cmd.Parameters.AddWithValue("@EmpName", empname);

                    int i = cmd.ExecuteNonQuery();//insert문 1=저장 0=저장 안됨
                    var sdr = cmd.ExecuteReader();
                    byte[] img = null;
                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("찾으시는 직원이 없습니다");
                        return;
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            img = (byte[])sdr["EmpImg"];
                            if (img != null)
                            {
                                try
                                {
                                    MemoryStream ms = new MemoryStream();
                                    ms.Write(img, 0, img.Length);
                                    pictureBox1.Image = new Bitmap(new MemoryStream(img));
                                }
                                catch (Exception)
                                {
                                    pictureBox1.Image = null;
                                }
                            }
                            emp.Add(new Employee()
                            {
                                EmpId = int.Parse(sdr.GetInt32(0).ToString()),
                                EmpName = sdr.GetString(1).ToString(),
                                EmpPass = int.Parse(sdr.GetInt32(2).ToString()),
                                WorkTime = int.Parse(sdr.GetInt32(4).ToString()),
                                Phone = sdr.GetString(5).ToString(),
                                Hiredate = DateTime.Parse(sdr.GetDateTime(6).ToString()),
                                Rank = int.Parse(sdr.GetInt32(7).ToString())

                            });
                            tboxSerach.Text = "";
                        }
                        dataGridView1.DataSource = emp;

                        SelectEmployee();
                    }
                    sdr.Close();
                }
                con.Close();
            }
        }//직원조회
    }
}

