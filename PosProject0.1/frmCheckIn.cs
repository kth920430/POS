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
    public partial class frmCheckIn : Form
    {
        List<CheckIn> employees = new List<CheckIn>();
        Control[] lobtn = new Control[8];
        Control[] lolab = new Control[8];
        Control[] glp = new Control[8];
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {           
            employees.Add(new CheckIn("01", "1234", "동욱"));
            employees.Add(new CheckIn("11", "1234", "창희"));
            employees.Add(new CheckIn("12", "1234", "철환"));
            employees.Add(new CheckIn("13", "1234", "태호"));

            for (int i = 0; i < employees.Count; i++)
            {
                glp[i] = new GroupBox();
                glp[i].Location = new Point(28 + i * 180, 35);
                glp[i].Size = new Size(126, 163);
                glp[i].Text = employees[i].EmpName;
                glp[i].Parent = splitContainer1.Panel1;

                lolab[i] = new Label();
                lolab[i].Parent = glp[i];               
                lolab[i].Location = new Point(25, 105);
                //lolab[i].Text = DateTime.Now.ToLongTimeString();

                lobtn[i] = new Button();
                lobtn[i].Parent = glp[i];
                lobtn[i].Text = "퇴근하기";
                lobtn[i].Size = new Size(114, 30);
                lobtn[i].Location = new Point(6 , 127);
                lobtn[i].Click += CheckOut;

                glp[i].Hide();
            }

        }

        private void CheckOut(object sender, EventArgs e)
        {
            
            Button chkout = (Button)sender;
            for (int i = 0; i < employees.Count; i++)
            {
                //이거고쳐야함
                if (chkout.Parent.Text == employees[i].EmpName)
                {
                    string cin = lolab[i].Text;
                    //DateTime time = Convert.ToDateTime(lolab[i].Text) - Convert.ToDateTime( DateTime.Now.ToLongTimeString());
                    MessageBox.Show(glp.Count().ToString());

                }
            }
            chkout.Parent.Hide();          
        }

        void btnNum_Click(object sender, EventArgs e)
        {
            txtEmpId.Text +=sender.ToString().Split(':')[1].ToString().Trim();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            

            for (int i = 0; i < employees.Count; i++)
            {
                if (txtEmpId.Text == employees[i].EmpId)
                {
                    lolab[i].Text = DateTime.Now.ToLongTimeString();
                    glp[i].Show();
                }
            }
            txtEmpId.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEmpId.Text = null;
        }

    }
}
