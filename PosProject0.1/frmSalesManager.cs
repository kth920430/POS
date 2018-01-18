using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PosProject0._1
{
    public partial class frmSalesManager : Form
    {
        SalesStatus status;
        public frmSalesManager()
        {
            InitializeComponent();
        }
        public frmSalesManager(SalesStatus f1) : this()
        {
            this.status = f1;
        }

        private void btnSalesStatus_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }
            status.Show();
        }
    }
}
