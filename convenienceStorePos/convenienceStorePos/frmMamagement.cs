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
    public partial class frmMamagement : Form
    {
        public frmMamagement()
        {
            InitializeComponent();
        }

        private void frmManagement_Load(object sender, EventArgs e)
        {

        }

        private void 품목등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoods fg = new frmGoods();
            fg.MdiParent = this;
            fg.Show();
        }

        private void 판매관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoodsMng fgm = new frmGoodsMng();
            fgm.MdiParent = this;
            fgm.Show();
        }

        private void 구매조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseView pv = new purchaseView();
            pv.MdiParent = this;
            pv.Show();
        }

        private void 구매입력ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseNew pn = new purchaseNew();
            pn.MdiParent = this;
            pn.Show();
        }

        private void 구매현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            purchaseRe pr = new purchaseRe();
            pr.MdiParent = this;
            pr.Show();
        }
    }
}
