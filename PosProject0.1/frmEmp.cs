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
        DataSet ds;
        SqlDataAdapter adapter;
        DataTable emp;
        DataRow employee;
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
            if (tboxEname.Text == "" || tboxENum.Text == "" || mtboxTel.Text == "" || cboxDept.Text == "" || cboxdate.Text == "" || dateTimePicker1.Text == "")
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
        private void Resets(DataSet ds)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            EmpLoad();
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
        private void EmpLoad()
        {
            using (var con = new Connector().getInstance())
            {

                using (var cmd = new SqlCommand("EmployeesLoad", con))
                {
                    adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    this.dataGridView1.Columns["EmpImg"].Visible = false;
                    dataGridView1.Columns[0].HeaderText = "사원번호";
                    dataGridView1.Columns[1].HeaderText = "사원명";
                    dataGridView1.Columns[2].HeaderText = "비밀번호";
                    dataGridView1.Columns[3].HeaderText = "사진";
                    dataGridView1.Columns[4].HeaderText = "근무시간";
                    dataGridView1.Columns[5].HeaderText = "전화번호";
                    dataGridView1.Columns[6].HeaderText = "입사일";
                    dataGridView1.Columns[7].HeaderText = "직급";
                }
            }

        }
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
            tboxENum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tboxEname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            mboxPass.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            mtboxTel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cboxdate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cboxDept.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

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
            Resets(ds);
        }//새로고침 
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckEmp() && EmpId())
            {
                emp = ds.Tables[0];
                employee = emp.NewRow();
                employee["EmpId"] = int.Parse(tboxENum.Text);//직원번호;
                employee["EmpName"] = tboxEname.Text.Trim().Replace(" ", "");
                employee["EmpPwd"] = int.Parse(mboxPass.Text);
                employee["EmpImg"] = null;
                employee["WorkTime"] = int.Parse(cboxdate.Text);
                employee["Phone"] = mtboxTel.Text;
                employee["HireDate"] = DateTime.Parse(dateTimePicker1.Text);
                employee["RankNum"] = int.Parse(cboxDept.Text);

                emp.Rows.Add(employee);

                FileStream fs = new FileStream(Img.ToString(), FileMode.Open, FileAccess.Read);
                byte[] bImg = new byte[fs.Length];
                fs.Read(bImg, 0, (int)fs.Length);
                using (var con = new Connector().getInstance())
                {

                    using (var cmd = new SqlCommand("SaveEmployee", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmpId", int.Parse(tboxENum.Text));
                        cmd.Parameters.AddWithValue("@EmpName", tboxEname.Text.Trim().Replace(" ", ""));
                        cmd.Parameters.AddWithValue("@EmpPwd", int.Parse(mboxPass.Text));
                        cmd.Parameters.AddWithValue("@EmpImg", bImg);
                        cmd.Parameters.AddWithValue("@WorkTime", int.Parse(cboxdate.Text));
                        cmd.Parameters.AddWithValue("@Phone", mtboxTel.Text);
                        cmd.Parameters.AddWithValue("@RankNum", int.Parse(cboxDept.Text));
                        cmd.Parameters.AddWithValue("@Hiredate", DateTime.Parse(dateTimePicker1.Text));
                        adapter.InsertCommand = cmd;
                        adapter.Update(ds);

                    }
                    Resets(ds);
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
                    adapter.DeleteCommand = con.CreateCommand();
                    adapter.DeleteCommand = cmd;
                    adapter.DeleteCommand.ExecuteNonQuery();
                }
                Resets(ds);
            }
        }//직원삭제
        private void btnModified_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("UpdateEmp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpId", int.Parse(tboxENum.Text));
                    cmd.Parameters.AddWithValue("@EmpName", tboxEname.Text.Trim().Replace(" ", ""));
                    cmd.Parameters.AddWithValue("@EmpPwd", int.Parse(mboxPass.Text));
                    cmd.Parameters.AddWithValue("@WorkTime", int.Parse(cboxdate.Text));
                    cmd.Parameters.AddWithValue("@Phone", mtboxTel.Text);
                    cmd.Parameters.AddWithValue("@RankNum", int.Parse(cboxDept.Text));
                    cmd.Parameters.AddWithValue("@Hiredate", DateTime.Parse(dateTimePicker1.Text));
                    adapter.UpdateCommand = con.CreateCommand();
                    adapter.UpdateCommand = cmd;
                    adapter.UpdateCommand.ExecuteNonQuery();
                }
                Resets(ds);
            }

        }//직원수정
        private void btnSerch_Click(object sender, EventArgs e)
        {

            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("EmpSerach", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpName", tboxSerach.Text);
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
                        }
                        sdr.Close();
                        adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        ds = new DataSet();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0];

                    }
                    con.Close();
                }
            }//직원조회

        }//직원조회
    }
}
