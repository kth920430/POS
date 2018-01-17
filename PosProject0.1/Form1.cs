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
<<<<<<< HEAD
        frmCheckIn fck = new frmCheckIn();
        frmSalesManager fsm;
        SalesStatus statusSale;
=======
        frmInventory fI = new frmInventory();
>>>>>>> 6e2203f0ad62d8e2801dc8f0577a9a95b2170ffe
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fck.MdiParent = this;
            fck.Dock = DockStyle.Fill;          
            fck.Show();           
        }

        private void btnSalesMan_Click(object sender, EventArgs e)
        {
            statusSale = new SalesStatus();
            statusSale.MdiParent = this;
            statusSale.Dock = DockStyle.Fill;

            fsm = new frmSalesManager(statusSale);
            fsm.MdiParent = this;
            fsm.Dock = DockStyle.Fill;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }
            fsm.Show();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }
            fck.Show();
        }
    }
}
