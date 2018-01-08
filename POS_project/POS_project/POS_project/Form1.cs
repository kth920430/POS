using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form4 f4 = new Form4();
        Form3 f3 = new Form3();
        Form5 f5 = new Form5();
        Form6 f6 = new Form6();
        Form7 f7 = new Form7();


        private void 현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {        
            f3.MdiParent = this;
            f3.Dock = DockStyle.Fill;
            
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }
            f3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = DateTime.Today.ToLongDateString();
            label2.Text += DateTime.Today.ToLongTimeString();
            Form2 f2 = new Form2();
            f2.ShowDialog();          
        }

        private void 회원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            f4.MdiParent = this;
            f4.Dock = DockStyle.Fill;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }

            f4.Show();
        }

        private void 품목관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f5.MdiParent = this;
            f5.Dock = DockStyle.Fill;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }

            f5.Show();
        }

        private void 판매등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f6.MdiParent = this;
            f6.Dock = DockStyle.Fill;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }

            f6.Show();
        }

        private void 자료관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f7.MdiParent = this;
            f7.Dock = DockStyle.Fill;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }

            f7.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Close();
            }
            this.Close();
        }

        private void 잠깐외출ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
