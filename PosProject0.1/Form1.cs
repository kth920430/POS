using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosProject0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmEmp emp = new frmEmp(); 
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
    }
}
