using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using static PosProject0._1.Form1;
using System.Reflection;

namespace PosProject0._1
{

    public partial class frmEmp : Form
    {
        DataSet ds,grade;
        SqlDataAdapter adapter;
        DataTable emp;
        DataRow employee;
        byte[] bImg = null;
        string Img = null;
        public frmEmp()
        {
            InitializeComponent();
        }
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
        }//모두 작성
        private bool EmpId()
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("CheckEmp", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmpId",tboxENum.Text);
                        var sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            MessageBox.Show("중복되는 사원이 있습니다.","알림",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                    catch (SqlException)
                    {
                        throw;
                    }
                }
            }
        }//직원 아이디 중복
        private void EmpLoad()
        {
            EmpView.AllowUserToAddRows = false;
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("EmployeesLoad", con))
                {
                    try
                    {
                        adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        ds = new DataSet();
                        adapter.Fill(ds);
                        EmpView.DataSource = ds.Tables[0];

                        grade = new DataSet();
                        adapter.Fill(grade);
                        foreach (DataRow row in grade.Tables[1].Rows)
                        {
                            cboxDept.Items.Add(row.ItemArray[0]);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    cboxdate.Items.Clear();
                    cboxdate.Items.Add(0);
                    #region EmpView
                    this.EmpView.Columns["EmpPwd"].Visible = false;
                    this.EmpView.Columns["EmpImg"].Visible = false;
                    this.EmpView.Columns["GradeNum"].Visible = false;
                    this.EmpView.Columns["GradeNum1"].Visible = false;
                    EmpView.Columns[0].HeaderText = "사원번호";
                    EmpView.Columns[1].HeaderText = "사원명";
                    EmpView.Columns[2].HeaderText = "비밀번호";
                    EmpView.Columns[3].HeaderText = "사진";
                    EmpView.Columns[4].HeaderText = "근무시간";
                    EmpView.Columns[5].HeaderText = "전화번호";
                    EmpView.Columns[6].HeaderText = "입사일";
                    EmpView.Columns[7].HeaderText = "";
                    EmpView.Columns[8].HeaderText = "";
                    EmpView.Columns[9].HeaderText = "직급";
                    EmpView.Columns[10].HeaderText = "시급";
                    EmpView.Columns[0].Width = 100;
                    EmpView.Columns[1].Width = 120;
                    EmpView.Columns[2].Width = 140;
                    EmpView.Columns[3].Width = 140;
                    EmpView.Columns[4].Width = 90;
                    EmpView.Columns[5].Width = 120;
                    EmpView.Columns[6].Width = 120;
                    EmpView.Columns[7].Width = 100;
                    #endregion
                }
            }
        }//예외처리
        private void LoadImg()   //이미지로드//예외처리
        {
            try
            {
                ImageConverter converter = new ImageConverter();
                bImg = (byte[])converter.ConvertTo(EmpImg.Image, typeof(byte[]));
            }
            catch (NotSupportedException)
            {
                throw;
            }
        }
        private void Empty()
        {
            EmpImg.Image = Properties.Resources.noimage;
            tboxEname.Text = mboxPass.Text = tboxENum.Text = mtboxTel.Text = cboxDept.Text = cboxdate.Text = dateTimePicker1.Text = "";
            tboxEname.Focus();
        }
        private void Resets(DataSet ds)
        {
            try
            {
                EmpView.DataSource = null;
                EmpView.DataSource = ds.Tables[0];
                EmpLoad();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var dlg = openFileDialog1.ShowDialog();
            if (dlg == DialogResult.OK)
            {
                Img = openFileDialog1.FileName;
                EmpImg.Image = new Bitmap(Img);
            }
        }//사진선택
        private void btnReset_Click(object sender, EventArgs e)
        {
            Resets(ds);
        }//새로고침 
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Empty();
        }//취소
        private void Parameter(SqlCommand cmd)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", int.Parse(tboxENum.Text));
                cmd.Parameters.AddWithValue("@EmpName", tboxEname.Text.Trim().Replace(" ", ""));
                cmd.Parameters.AddWithValue("@EmpPwd", int.Parse(mboxPass.Text));
                cmd.Parameters.AddWithValue("@EmpImg", bImg);
                cmd.Parameters.AddWithValue("@WorkTime", int.Parse(cboxdate.Text));
                cmd.Parameters.AddWithValue("@Phone", mtboxTel.Text);
                cmd.Parameters.AddWithValue("@GradeName", cboxDept.Text);
                cmd.Parameters.AddWithValue("@Hiredate", DateTime.Parse(dateTimePicker1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("사번과 비밀번호,시간은 숫자를 입력해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//속성//예외처리
        private void frmEmp_Load(object sender, EventArgs e)
        {
            EmpLoad();
            clsVirtualKB.Open();
            mboxPass.PasswordChar = '*';
            EmpImg.Image = Properties.Resources.noimage;
        }//폼로드
        private void btnEmpSave_Click(object sender, EventArgs e)
        {
            if (CheckEmp() && EmpId())
            {
                emp = ds.Tables[0];
                employee = emp.NewRow();
                emp.Rows.Add(employee);
                LoadImg();
                using (var con = new Connector().getInstance())
                {
                    using (var cmd = new SqlCommand("SaveEmployee", con))
                    {
                        try
                        {
                            Parameter(cmd);
                            adapter.InsertCommand = cmd;
                            adapter.Update(ds);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("데이터가 유효하지 않아 상품 저장을 실패 하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Resets(ds);
                }
            }
            else
            {
                Empty();
                return;
            }
        }//직원등록//예외처리
        private void btnEmpDel_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("EmpDelete", con))
                {

                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@EmpId", tboxENum.Text);
                        adapter.DeleteCommand = con.CreateCommand();
                        adapter.DeleteCommand = cmd;
                        adapter.DeleteCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {

                        throw;
                    }
                }
                Resets(ds);
            }
            Empty();
        }//직원삭제//예외처리
        private void btnEmpModi_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("UpdateEmp", con))
                {
                    LoadImg();
                    try
                    {
                        Parameter(cmd);
                        adapter.UpdateCommand = con.CreateCommand();
                        adapter.UpdateCommand = cmd;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("사번과 비밀번호,시간은 숫자를 입력해 주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Resets(ds);
            }
            Empty();
        }//직원수정//예외처리
        private void EmpView_Click(object sender, EventArgs e)
        {
            try
            {

                tboxENum.Text = EmpView.CurrentRow.Cells[0].Value.ToString();
                tboxEname.Text = EmpView.CurrentRow.Cells[1].Value.ToString();
                mboxPass.Text = EmpView.CurrentRow.Cells[2].Value.ToString();
                mtboxTel.Text = EmpView.CurrentRow.Cells[5].Value.ToString();
                cboxdate.Text = EmpView.CurrentRow.Cells[4].Value.ToString();
                cboxDept.Text = EmpView.CurrentRow.Cells[9].Value.ToString();
                lbldate.Text = EmpView.CurrentRow.Cells[6].Value.ToString();
            }
            catch (NullReferenceException)
            {

                throw;
            }
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
                                    EmpImg.Image = new Bitmap(new MemoryStream(img));
                                }
                                catch (Exception)
                                {
                                    EmpImg.Image = null;
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
        }//데이터 클릭시 나타남//예외처리
        private void EmpView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmpView.BeginEdit(true);
            }
            catch (Exception)
            {

                throw;
            }
        }//데이터 클릭시 나타남//예외처리
        private void tboxSerach_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < EmpView.RowCount; i++)
                {
                    bool cell = EmpView.Rows[i].Cells[1].Value.ToString().ToUpper().Contains(tboxSerach.Text.ToUpper().Trim());
                    if (!cell)
                    {

                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[EmpView.DataSource];
                        currencyManager1.SuspendBinding();
                        EmpView.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    else if (cell)
                    {

                        EmpView.Rows[i].Visible = true;
                    }
                    else if (tboxSerach.Text == null)
                    {
                        EmpView.Rows[i].Visible = true;
                    }
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }//직원이름//예외처리
     }
}
