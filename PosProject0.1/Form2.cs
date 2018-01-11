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
    public partial class Form2 : Form
    {
        DataTable dt;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(DataTable dt) : this()
        {
            this.dt = dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;

        }
    }
}
