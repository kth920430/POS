using convenienceStorePos;
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
    public partial class frmCash : Form
    {
        public frmCash()
        {
            InitializeComponent();
        }
        //나중에 수정해야할듯...
        int sum;

        int num;
        string line;
        bool parsed;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //할인 금액 
            ((frmSale)(this.Owner)).lblDC.Text = ((frmSale)(this.Owner)).lblSumdis.Text.ToString();

            //받은 금액
            ((frmSale)(this.Owner)).lblget.Text = txtInputMoney.Text.ToString();
            line = ((frmSale)(this.Owner)).lblget.Text;
            parsed = Int32.TryParse(line, out num);


            //결제해야 할 금액
            sum = int.Parse(((frmSale)(this.Owner)).lblSummoney.Text.ToString()) - int.Parse(((frmSale)(this.Owner)).lblSumdis.Text.ToString());
            ((frmSale)(this.Owner)).lblneed.Text = sum.ToString();
            
            //계산
            if (!parsed)
            {
                MessageBox.Show("금액을 다시 입력해 주세요.");
            }
            else
            {

                ((frmSale)(this.Owner)).lblChange.Text = (int.Parse(((frmSale)(this.Owner)).lblget.Text.ToString()) - sum).ToString();
                this.Close();
            }
            ((frmSale)(this.Owner)).txtBarcode.Select();
        }
    }
}
