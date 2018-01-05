using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convenienceStorePos
{
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                MessageBox.Show("Test"); 
            }
            
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            frmSale fs = new frmSale();
            fs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmMamagement().Show();
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
