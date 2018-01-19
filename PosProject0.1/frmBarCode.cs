using convenienceStorePos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PosProject0._1
{
    public partial class frmBarCode : Form
    {
        public frmBarCode()
        {
            InitializeComponent();
            
        }
        //추 후 클래스 추가할 것
        frmSale frm = null;
        int sumMoney;
        int rowsSum;
        int sumCount;
        int Sumdiscount;
        int Sumlbltotal;
        int SumDC;

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm = Owner as frmSale;

            List<clsSale> list = frm.List;
            List<clsSale> list2 = new List<clsSale>();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("ProductsSale", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uBarCode", this.txtbarCode.Text);
                    var sdr = cmd.ExecuteReader();

                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("다시 한번 눌러주세요.");
                        return;
                    }
                    else
                    {
                        if (((frmSale)(this.Owner)).dataGridView1.Rows.Count.ToString() == "0")
                        {
                            while (sdr.Read())
                            {
                                list.Add(new clsSale()
                                {
                                    ProNum = int.Parse(sdr["ProNum"].ToString()),
                                    ProName = sdr["ProName"].ToString(),
                                    ProCount = 1,
                                    UnitPrice = int.Parse(sdr["UnitPrice"].ToString()),
                                    Discount = 0,
                                    EventName = sdr["EveName"].ToString()
                                });
                            }
                        }
                        else
                        {
                            
                            //검색만해서 있으면 true 없으면 false
                           
                            int sw = 0;
                            while (sdr.Read())
                            {
                                list2.Add(new clsSale()
                                {
                                    ProNum = int.Parse(sdr["ProNum"].ToString()),
                                    ProName = sdr["ProName"].ToString(),
                                    ProCount = 1,
                                    UnitPrice = int.Parse(sdr["UnitPrice"].ToString()),
                                    Discount = 0,
                                    EventName = sdr["EveName"].ToString()
                                });
                            }

                            for (int i = 0; i < ((frmSale)(this.Owner)).dataGridView1.Rows.Count; i++)
                            {
                                if (((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[5].Value.ToString() == "1+1 행사상품")
                                {
                                    if (((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[0].Value.ToString() == list2[0].ProNum.ToString())
                                    {
                                        ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                        sw++;

                                        //총 가격을 갯수로 나눈 값을 rowsSum에 넣어둔다.
                                        rowsSum = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value.ToString()) / (int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) - 1);

                                        //1+1 할인 가격 적용
                                        if (int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) % 2 == 0)
                                        {
                                           
                                            ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value =  int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value.ToString()) + rowsSum;
                                            //((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value = SumDC.ToString();
                                        }
                                        ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value = rowsSum * int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString());
                                    } 
                                }
                                else if (((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[5].Value.ToString() == "2+1 행사상품")
                                {
                                    if (((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[0].Value.ToString() == list2[0].ProNum.ToString())
                                    {
                                        ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                        sw++;

                                        //총 가격을 갯수로 나눈 값을 rowsSum에 넣어둔다.
                                        rowsSum = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value.ToString()) / (int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) - 1);
                                        //2+1 할인 가격 적용
                                        if (int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) % 3 == 0)
                                        {
                                            ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value.ToString()) + rowsSum;
                                            //((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value = SumDC.ToString();
                                        }
                                        ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value = rowsSum * int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString());
                                    }
                                }
                                else
                                {
                                    if (((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[0].Value.ToString() == list2[0].ProNum.ToString())
                                    {
                                        ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                        sw++;

                                        //총 가격을 갯수로 나눈 값을 rowsSum에 넣어둔다.
                                        rowsSum = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value.ToString()) / (int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) - 1);
                                        ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value = rowsSum * int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString());
                                    }
                                }
                            }
                            if (sw ==0)
                            {
                                list.Add(list2[0]);
                            }
                        }
                        
                        ((frmSale)(this.Owner)).dataGridView1.DataSource = null;
                        ((frmSale)(this.Owner)).dataGridView1.DataSource = list;
                        sdr.Close();
                    }
                }

            }
            ((frmSale)(this.Owner)).dataGridView1.ReadOnly = true;
            //((frmSale)(this.Owner)).dataGridView1.
            ((frmSale)(this.Owner)).dataGridView1.Columns[0].HeaderText = "상품 번호";
            ((frmSale)(this.Owner)).dataGridView1.Columns[0].Width = 100;
            ((frmSale)(this.Owner)).dataGridView1.Columns[1].HeaderText = "상 품 명";
            ((frmSale)(this.Owner)).dataGridView1.Columns[1].Width = 300;
            ((frmSale)(this.Owner)).dataGridView1.Columns[2].HeaderText = "수 량";
            ((frmSale)(this.Owner)).dataGridView1.Columns[2].Width = 80;
            ((frmSale)(this.Owner)).dataGridView1.Columns[3].HeaderText = "단 가";
            ((frmSale)(this.Owner)).dataGridView1.Columns[4].HeaderText = "할 인";
            ((frmSale)(this.Owner)).dataGridView1.Columns[5].HeaderText = "할 인 행 사";
            ((frmSale)(this.Owner)).dataGridView1.Columns[5].Width = 115;

            txtbarCode.Text = null;
            SumTotal();
            ((frmSale)(this.Owner)).txtBarcode.Select();
        }

        private void SumTotal()
        {
            for (int i = 0; i < ((frmSale)(this.Owner)).dataGridView1.Rows.Count; i++)
            {
                sumCount += int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString());
                sumMoney += int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value.ToString());
                Sumdiscount += int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value.ToString());
                Sumlbltotal += int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[3].Value.ToString()) - int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            ((frmSale)(this.Owner)).lblSumcount.Text = sumCount.ToString();
            ((frmSale)(this.Owner)).lblSummoney.Text = sumMoney.ToString();
            ((frmSale)(this.Owner)).lblSumdis.Text = Sumdiscount.ToString();
            ((frmSale)(this.Owner)).lblPrice.Text = Sumlbltotal.ToString();
            sumCount = 0;
            sumMoney = 0;
            Sumdiscount = 0;
            Sumlbltotal = 0;
        }

        private void frmBarCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((frmSale)(this.Owner)).txtBarcode.Focus();
        }
    }
}

