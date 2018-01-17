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

        private void frmSalesManager_Load(object sender, EventArgs e)
        {
            
        }
        public frmSalesManager(SalesStatus f1):this()
        {
            this.status = f1;
        }
        private void btnSalesStatus_Click(object sender, EventArgs e)
        {
            status.Show();
        }
    }
}
