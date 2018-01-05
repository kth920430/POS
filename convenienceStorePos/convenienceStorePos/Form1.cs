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
    public partial class Form1 : Form
    {
        string id = "asd123";
        string pwd = "123123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "asd123" && txtPwd.Text == "123123")
            {
                Main main = new Main();
                main.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("ID 혹은 PW가 다릅니다. 다시 입력해 주세요.");
                txtPwd.Text = null;
            }
            
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            txtPwd.PasswordChar = '*';
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
