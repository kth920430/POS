﻿using System;
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
        frmCheckIn fck = new frmCheckIn();
        frmSalesManager fsm;
        SalesStatus statusSale;
        frmInventory fI = new frmInventory();
        public Form1()
        {
            InitializeComponent();
        }

        private void 환경설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fI.MdiParent = this;
            fI.Dock = DockStyle.Fill;

            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[i].Hide();
            }

            fI.Show();
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
