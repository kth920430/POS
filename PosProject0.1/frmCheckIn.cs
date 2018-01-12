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

        private void CheckOut(object sender, EventArgs e)
        {
            DateTime chkDate = DateTime.Now;

            Button chkout = (Button)sender;
            for (int i = 0; i < employees.Count; i++)
            {
                //이거고쳐야함
                if (chkout.Parent.Text == employees[i].EmpName)
                {
                    CheckLogin(2, employees[i].EmpId, chkDate);
                }
            }

            for (int i = 0; i < employees.Count; i++)
            {
                CheckLogin(0, employees[i].EmpId, DateTime.Now);
            }
            //chkout.Parent.Hide();          
        }

        void btnNum_Click(object sender, EventArgs e)
        {
            txtEmpId.Text +=sender.ToString().Split(':')[1].ToString().Trim();
        }

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
                        MessageBox.Show("첫출근이양");
                        InsertLog(loginNum, chkDate);
                    }
                    else
                    {
                        while (sdr.Read())
                        {
                            if (islogin == 1 || islogin == 0)
                            {
                                if (sdr["ChkOutDate"].ToString() == "")
                                {
                                    LogOnEmp(loginNum, Convert.ToDateTime(sdr["ChkInDate"]));
                                    MessageBox.Show("로그인이 이미 되있는거");
                                }
                                else
                                {
                                    InsertLog(loginNum, chkDate);
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
                        LogOnEmp(loginNum, checkIn);
                        MessageBox.Show("출근 완료!");
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
                        MessageBox.Show("퇴근합니당~!");
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
        private void button1_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = null;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
