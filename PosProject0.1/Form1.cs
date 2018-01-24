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
    public partial class Form1 : Form
    {
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
        public Form1()
        {
            InitializeComponent();
        }
        frmEmp emp = new frmEmp();
        frmProducts pro = new frmProducts();
        private void 회원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            emp.MdiParent = this;
            emp.Dock = DockStyle.Fill;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }

            emp.Show();
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrefer pre = new frmPrefer();
            pre.ShowDialog();
        }

        private void 품목관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pro.MdiParent = this;
            pro.Dock = DockStyle.Fill;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }

            pro.Show();
        }

        private void 출근ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
