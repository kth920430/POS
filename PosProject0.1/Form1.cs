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
        frmCheckIn fck = new frmCheckIn();
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
    }
}
