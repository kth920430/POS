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
        DataTable orderitem;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(DataTable dt) : this()
        {
            //this.ds = ds;

            //friendsTable = ds.Tables[0];
            //DataRowCollection rows = friendsTable.Rows;

            orderitem = dt;

            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            order();
        }

        private void order()
        {
            dataGridView1.DataSource = orderitem;
            dataGridView1.Columns[0].Width = 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택한 품목에 대해 발주신청을 하시겠습니까?", "발주신청", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Hide();
                frmInventory fi = (frmInventory)Owner;
                fi.tcInven1.SelectedTab = fi.tcInven1.TabPages[1];
                //tcInven1.SelectedTab = tcInven1.TabPages[1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
