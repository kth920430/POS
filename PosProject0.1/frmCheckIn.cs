using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject0._1
{
    public partial class frmCheckIn : Form
    {
        List<CheckIn> employees = new List<CheckIn>();
        int gboxindex = 0;
        int gboxlox = 0;
        int gboxloy = 0;
        Control[] lobtn;
        Control[] lolab;
        Control[] glp;
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("EmployeesLoad", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        employees.Add(new CheckIn(sdr.GetInt32(0), sdr.GetInt32(2), sdr.GetString(1)));
                    }
                }
            }           
            lobtn = new Control[employees.Count];
            lolab = new Control[employees.Count];
            glp = new Control[employees.Count];

            for (int i = 0; i < employees.Count; i++)
            {
                CheckLogin(0,employees[i].EmpId, DateTime.Now);
            }
        }
        //퇴근버튼 클릭시
        private void CheckOut(object sender, EventArgs e)
        {
            
            DateTime chkDate = DateTime.Now;
            gboxindex = 0;
            gboxlox = 0;
            gboxloy = 0;
            Button chkout = (Button)sender;
            
            for (int i = 0; i < employees.Count; i++)
            {
                if (chkout.Parent.Text == employees[i].EmpName)
                {
                    CheckLogin(2, employees[i].EmpId, chkDate);
                    InsertTot(employees[i].EmpId);
                }
            }
            //panal1의 모든 컨트롤 지우기
            foreach (var item in splitContainer1.Panel1.Controls)
            {
                Control cons = (Control)item;
                cons.Hide();

            }
            
            //재생성
            for (int i = 0; i < employees.Count; i++)
            {
                CheckLogin(0, employees[i].EmpId, DateTime.Now);

            }
            //chkout.Parent.Hide();                           
        }

        //퇴근시 tottime값 입력
        private void InsertTot(int empId)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("SaveTotTime", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("고생하셨습니다.");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("failed");
                        return;
                    }
                }
            }
        }

        //숫자패드 입력시 값 입력
        void btnNum_Click(object sender, EventArgs e)
        {
            txtEmpId.Text +=sender.ToString().Split(':')[1].ToString().Trim();
        }

        //엔터버튼 클릭시
        private void btnEnter_Click(object sender, EventArgs e)
        {
            int loginNum = int.Parse(txtEmpId.Text);
            DateTime chkDate = DateTime.Now;
            for (int i = 0; i < employees.Count; i++)
            {
                if (loginNum == employees[i].EmpId)
                {
                    CheckLogin(1, loginNum, chkDate);
                }              
            }
       
            txtEmpId.Text = null;
            txtEmpId.Focus();
        }

        //로그인 여부 체크
        private void CheckLogin(int islogin,int loginNum, DateTime chkDate)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("FindLog", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empid", loginNum);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    
                    if (islogin == 1 && !sdr.HasRows)
                    {
                        //검색결과가 없을때 (초기화후 첫출근/신입사원)
                        InsertLog(loginNum, chkDate);
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            if (islogin == 1)
                            {
                                if (sdr["ChkOutDate"].ToString() == "")
                                {
                                    MessageBox.Show("이미 출근완료된 사원입니다.");
                                }
                                else
                                {
                                    InsertLog(loginNum, chkDate);
                                }
                            }
                            else if (islogin == 0)
                            {
                                if (sdr["ChkOutDate"].ToString() == "")
                                {
                                    //프로그램 강제종료시 출근되있던 인원 재출력
                                    LogOnEmp(loginNum, Convert.ToDateTime(sdr["ChkInDate"]));
                                }
                            }
                            else if (islogin == 2)
                            {
                                LogOutEmp(loginNum, chkDate, sdr["ChkInDate"]);
                            }
                            
                        }

                    }
                }
            }
        }

        //출근 시간 기입
        private void InsertLog(int loginNum, DateTime checkIn)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("InsertLog", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empid", loginNum);
                    cmd.Parameters.AddWithValue("@chkIn", checkIn);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        //출근 성공시
                        LogOnEmp(loginNum, checkIn);                       
                        return;
                    }
                    else
                    {
                        MessageBox.Show("failed");
                        return;
                    }
                }
            }       
        }

        //퇴근
        private void LogOutEmp(int empId,DateTime chkDate, object indate)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("CheckOut", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empid", empId);
                    cmd.Parameters.AddWithValue("@chkIn", indate);
                    cmd.Parameters.AddWithValue("@chkOut", chkDate);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        //퇴근성공시
                        return;
                    }
                    else
                    {
                        MessageBox.Show("failed");
                        return;
                    }
                }
            }
        }
        //출근되있는 인원을 폼에 생성
        private void LogOnEmp(int loginNum, DateTime checkIn)
        {
            if (gboxindex != 0 && gboxindex %4 == 0)
            {
                gboxloy += 1;
                gboxlox = 0;
            }
            for (int i = 0; i < employees.Count; i++)
            {
                if (loginNum == employees[i].EmpId)
                {
                    glp[gboxindex] = new GroupBox();
                    glp[gboxindex].Location = new Point(28 + gboxlox * 180, 35 + gboxloy *200);
                    glp[gboxindex].Size = new Size(126, 163);
                    glp[gboxindex].Text = employees[i].EmpName;
                    glp[gboxindex].Parent = splitContainer1.Panel1;

                    lolab[gboxindex] = new Label();
                    lolab[gboxindex].Parent = glp[gboxindex];
                    lolab[gboxindex].Location = new Point(25, 105);
                    lolab[gboxindex].Text = checkIn.ToLongTimeString();

                    lobtn[gboxindex] = new Button();
                    lobtn[gboxindex].Parent = glp[gboxindex];
                    lobtn[gboxindex].Text = "퇴근하기";
                    lobtn[gboxindex].Size = new Size(114, 30);
                    lobtn[gboxindex].Location = new Point(6, 127);
                    lobtn[gboxindex].Click += CheckOut;

                    gboxindex += 1;
                    gboxlox += 1;                
                }
                
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = null;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            Commute cmu = new Commute();
            cmu.Show();
        }
    }
}
