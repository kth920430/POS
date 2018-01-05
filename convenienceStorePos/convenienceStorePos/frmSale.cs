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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Location = new Point(this.ClientSize.Width / 2 - label1.Width / 2, this.ClientSize.Height / 2 - label1.Height / 2);
            lblDate.Text = DateTime.Now.ToString();


            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
