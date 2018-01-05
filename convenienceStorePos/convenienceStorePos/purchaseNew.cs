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
    public partial class purchaseNew : Form
    {
        public purchaseNew()
        {
            InitializeComponent();
        }

        private void purchaseNew_Load(object sender, EventArgs e)
        {
            lbloutDate.Text = DateTime.Today.Date.ToString("yyyy-MM-dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendar cal = new Calendar();
            cal.ShowDialog();
        }
    }
}
