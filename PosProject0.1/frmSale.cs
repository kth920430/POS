using PosProject0._1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace convenienceStorePos
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
            //포커스 바코드 텍스트 박스에 넣기
            txtBarcode.Select();
        }
        DataSet ds;
        DataTable table;
        int rowsSum;
        int PulSum;

        //갯수
        int Count;
        List<clsSale> list = new List<clsSale>();
        List<clsSale> list2 = new List<clsSale>();
        bool rows;

        //상단 라벨 합계
        int sumCount = 0;
        int sumMoney = 0;
        int Sumdiscount = 0;
        int Sumlbltotal = 0;

        //할인 된 가격
        int Dc = 0;

        //할인 - 안쓰기러함 ㅠ
        //int Opay = 0;

        internal List<clsSale> List { get => list; set => list = value; }


        //현재 시간 나타내기
        private void frmSale_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
        }
        //현재 시간 나타내기
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Location = new Point(this.ClientSize.Width / 2 - label1.Width / 2, this.ClientSize.Height / 2 - label1.Height / 2);
            lblDate.Text = DateTime.Now.ToString();
        }

        //폼 종료
        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //바코드 입력 창 불러오기
        private void btnCode_Click(object sender, EventArgs e)
        {
            frmBarCode fbc = new frmBarCode
            {
                Owner = this
            }
            ;
            fbc.ShowDialog(this);
        }

        //비닐봉지 추가 버튼
        private void btnAddPB_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("ProductsSale", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uBarCode", 0);
                    var sdr = cmd.ExecuteReader();

                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("다시 한번 눌러주세요.");
                        return;
                    }
                    else
                    {
                        //봉투 버튼 클릭 시, 카운터 증가
                        if (dataGridView1.Rows.Count.ToString() == "0")
                        {
                            while (sdr.Read())
                            {
                                List.Add(new clsSale()
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
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {

                                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "100")
                                {
                                    rows = false;
                                    while (sdr.Read())
                                    {
                                        if (rows == false)
                                        {
                                            dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                            dataGridView1.Rows[i].Cells[3].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * 20;
                                        }
                                    }
                                }
                                else
                                {
                                    rows = true;
                                }
                            }
                            if (rows == true)
                            {
                                while (sdr.Read())
                                {
                                    List.Add(new clsSale()
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
                        }
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = List;
                        sdr.Close();
                    }

                }
                // MessageBox.Show(rows.ToString());
            }

            dataGridView1.Columns[0].HeaderText = "상품 번호";
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].HeaderText = "상 품 명";
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].HeaderText = "수 량";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "단 가";
            dataGridView1.Columns[4].HeaderText = "할 인";
            dataGridView1.Columns[5].HeaderText = "할 인 행 사";
            dataGridView1.Columns[5].Width = 115;


            SumTotal2();
            BarCodeFocus();
        }

        //포커스
        private void BarCodeFocus()
        {
            txtBarcode.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsVirtualKB.Open();

        }

        //화면 초기화
        private void btnReset_Click(object sender, EventArgs e)
        {
            list.Clear();
            dataGridView1.DataSource = null;
            SumTotal2();
            PayReset();
            BarCodeFocus();
        }
        private void SumTotal2()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sumCount += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                sumMoney += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                Sumdiscount += int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                Sumlbltotal += int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) - int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            lblSumcount.Text = sumCount.ToString();
            lblSummoney.Text = sumMoney.ToString();
            lblSumdis.Text = Sumdiscount.ToString();
            lblPrice.Text = Sumlbltotal.ToString();
            sumCount = 0;
            sumMoney = 0;
            Sumdiscount = 0;
            Sumlbltotal = 0;
        }

        //선택 삭제
        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(item);
            }

            SumTotal2();
            BarCodeFocus();
        }
        //카드결제 누를 시,
        private void btnCard_Click(object sender, EventArgs e)
        {

        }
        // 현금 결제 누를 시,
        private void btnCash_Click(object sender, EventArgs e)
        {
            frmCash fc = new frmCash();
            fc.Owner = this;
            fc.ShowDialog(this);
        }
        // 결제하기 버튼 눌렀을 때!
        private void btnPay_Click(object sender, EventArgs e)
        {
            //결제하기 버튼이당....
            if (lblneed.Text.ToString() != "")
            {
                if (MessageBox.Show("결제 하시겠습니까?", "결제하기", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
                        {
                            con.Open();

                            SqlDataAdapter dataAdapter = new SqlDataAdapter();
                            dataAdapter.SelectCommand = new SqlCommand("FindInventory", con);
                            ds = new DataSet();
                            dataAdapter.Fill(ds);
                            table = ds.Tables[0];
                            using (var cmd = new SqlCommand("UpdateInventory", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                for (int j = 0; j < table.Rows.Count; j++)
                                {
                                    // MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                                    // MessageBox.Show(table.Rows[j].ItemArray[1].ToString());
                                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == table.Rows[j].ItemArray[1].ToString())
                                    {

                                        MessageBox.Show("찾은 품번" + dataGridView1.Rows[i].Cells[0].Value.ToString());
                                        Count = int.Parse(table.Rows[j].ItemArray[2].ToString()) - int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                        MessageBox.Show("찾을 품번" + table.Rows[j].ItemArray[1].ToString());
                                        cmd.Parameters.AddWithValue("@UpdatePronum", int.Parse(table.Rows[j].ItemArray[1].ToString()));
                                        MessageBox.Show("변경할 카운트 값 " + Count.ToString());
                                        cmd.Parameters.AddWithValue("@UpdateCount", Count);
                                        var sdr = cmd.ExecuteReader();
                                        sdr.Close();
                                    }
                                }

                            }





                        }
                    }
                    list.Clear();
                    dataGridView1.DataSource = null;
                    SumTotal2();
                    PayReset();
                }
            }
            else
            {
                MessageBox.Show("결제 방법을 선택해 주세요");
            }
        }


        private void PayReset()
        {
            lblneed.Text = null;
            lblDC.Text = null;
            lblget.Text = null;
            lblChange.Text = null;
        }

        //할인 버튼 - 안쓰기러함 ㅠ
        //private void btnDC_Click(object sender, EventArgs e)
        //{
        //    if (lblneed.Text.ToString() != "")
        //    {
        //        //할인 할 가격을 표시해줌
        //        Opay = int.Parse(lblneed.Text.ToString());

        //        lblDC.Text = (Opay / 10).ToString();

        //        //할인해서 결제할 금액을 표시해 줌

        //        lblneed.Text = ((Opay / 10)*9).ToString();
        //        lblChange.Text = (int.Parse(lblget.Text.ToString()) - int.Parse(lblneed.Text.ToString())).ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("결제할 금액이 없습니다.");
        //    }
        //}


        //바코드를 찍었을 경우! 표시하도록...
        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
                {
                    con.Open();
                    using (var cmd = new SqlCommand("ProductsSale", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@uBarCode", txtBarcode.Text.ToString());
                        var sdr = cmd.ExecuteReader();

                        if (!sdr.HasRows)
                        {
                            MessageBox.Show("다시 한번 눌러주세요.");
                            return;
                        }
                        else
                        {
                            if (dataGridView1.Rows.Count.ToString() == "0")
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

                                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                                {
                                    if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "1+1 행사상품")
                                    {
                                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == list2[0].ProNum.ToString())
                                        {
                                            dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                            sw++;

                                            rowsSum = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) / (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) - 1);
                                            //1+1 구현
                                            if (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) % 2 == 0)
                                            {
                                                dataGridView1.Rows[i].Cells[4].Value = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + rowsSum;
                                            }
                                            dataGridView1.Rows[i].Cells[3].Value = rowsSum * int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                        }
                                    }
                                    else if (dataGridView1.Rows[i].Cells[5].Value.ToString() == "2+1 행사상품")
                                    {
                                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == list2[0].ProNum.ToString())
                                        {
                                            dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                            sw++;

                                            rowsSum = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) / (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) - 1);
                                            //2+1 구현
                                            if (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) % 3 == 0)
                                            {

                                                dataGridView1.Rows[i].Cells[4].Value = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()) + rowsSum;
                                            }
                                            dataGridView1.Rows[i].Cells[3].Value = rowsSum * int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == list2[0].ProNum.ToString())
                                        {
                                            dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                            sw++;

                                            rowsSum = int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()) / (int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) - 1);
                                            //일반 상품

                                            dataGridView1.Rows[i].Cells[3].Value = rowsSum * int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                                        }
                                    }
                                }
                                if (sw == 0)
                                {
                                    list.Add(list2[0]);
                                }
                            }
                            dataGridView1.DataSource = null;

                            dataGridView1.DataSource = list;
                            sdr.Close();
                        }
                    }
                }


                dataGridView1.Columns[0].HeaderText = "상품 번호";
                dataGridView1.Columns[0].Width = 100;
                dataGridView1.Columns[1].HeaderText = "상 품 명";
                dataGridView1.Columns[1].Width = 300;
                dataGridView1.Columns[2].HeaderText = "수 량";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].HeaderText = "단 가";
                dataGridView1.Columns[4].HeaderText = "할 인";
                dataGridView1.Columns[5].HeaderText = "할 인 행 사";
                dataGridView1.Columns[5].Width = 115;

                txtBarcode.Text = null;
                SumTotal2();
                BarCodeFocus();
            }
        }

        //물품 갯수 증가
        private void btnCountUp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                PulSum = int.Parse(dataGridView1.SelectedCells[3].Value.ToString()) / int.Parse(dataGridView1.SelectedCells[2].Value.ToString());
                dataGridView1.SelectedCells[2].Value = int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) + 1;
                dataGridView1.SelectedCells[3].Value = int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) * PulSum;
                if (dataGridView1.SelectedCells[5].Value.ToString() == "1+1 행사상품")
                {
                    if (int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) % 2 == 0)
                    {
                        dataGridView1.SelectedCells[4].Value = int.Parse(dataGridView1.SelectedCells[4].Value.ToString()) + PulSum;
                    }

                }
                else if (dataGridView1.SelectedCells[5].Value.ToString() == "2+1 행사상품")
                {
                    if (int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) % 3 == 0)
                    {
                        dataGridView1.SelectedCells[4].Value = int.Parse(dataGridView1.SelectedCells[4].Value.ToString()) + PulSum;
                    }
                }
                PulSum = 0;
                SumTotal2();
                BarCodeFocus();
                txtBarcode.Select();
            }
            else
            {
                MessageBox.Show("상품이 없습니다.");
            }
        }

        private void btnCountDown_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                PulSum = int.Parse(dataGridView1.SelectedCells[3].Value.ToString()) / int.Parse(dataGridView1.SelectedCells[2].Value.ToString());
                if (int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) == 1)
                {
                    MessageBox.Show("수량이 1개입니다. 상품 취소를 해주세요.");
                }
                else
                {
                    dataGridView1.SelectedCells[2].Value = int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) - 1;
                    dataGridView1.SelectedCells[3].Value = int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) * PulSum;
                    if (dataGridView1.SelectedCells[5].Value.ToString() == "1+1 행사상품")
                    {
                        if (int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) % 2 == 1)
                        {
                            dataGridView1.SelectedCells[4].Value = int.Parse(dataGridView1.SelectedCells[4].Value.ToString()) - PulSum;
                        }

                    }
                    else if (dataGridView1.SelectedCells[5].Value.ToString() == "2+1 행사상품")
                    {
                        if (int.Parse(dataGridView1.SelectedCells[2].Value.ToString()) % 3 == 2)
                        {
                            dataGridView1.SelectedCells[4].Value = int.Parse(dataGridView1.SelectedCells[4].Value.ToString()) - PulSum;
                        }
                    }
                }
                PulSum = 0;
                SumTotal2();
                BarCodeFocus();
                txtBarcode.Select();
            }
            else
            {
                MessageBox.Show("상품이 없습니다.");
            }
        }
        //바코드 찍어서 물건 환불
        private void btnRefundCash_Click(object sender, EventArgs e)
        {
            int ReNum;
            

            if (lblneed.Text.ToString() != "")
            {
                if (MessageBox.Show("환불 하시겠습니까?", "결제하기", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
                        {
                            con.Open();

                            SqlDataAdapter dataAdapter = new SqlDataAdapter();
                            dataAdapter.SelectCommand = new SqlCommand("FindInventory", con);
                            ds = new DataSet();
                            dataAdapter.Fill(ds);
                            table = ds.Tables[0];
                            using (var cmd = new SqlCommand("UpdateInventory", con))
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                for (int j = 0; j < table.Rows.Count; j++)
                                {
                                    // MessageBox.Show(dataGridView1.Rows[i].Cells[0].Value.ToString());
                                    // MessageBox.Show(table.Rows[j].ItemArray[1].ToString());
                                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == table.Rows[j].ItemArray[1].ToString())
                                    {
                                        Count = int.Parse(table.Rows[j].ItemArray[2].ToString()) + int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());

                                        cmd.Parameters.AddWithValue("@UpdatePronum", int.Parse(table.Rows[j].ItemArray[1].ToString()));
                                        cmd.Parameters.AddWithValue("@UpdateCount", Count);
                                        var sdr = cmd.ExecuteReader();
                                        sdr.Close();
                                    }
                                }
                            }
                            using (var cmd = new SqlCommand("SaveBook", con))
                            {

                            }
                        }
                    }

                    list.Clear();
                    dataGridView1.DataSource = null;
                    SumTotal2();
                    PayReset();
                }
            }
            else
            {
                MessageBox.Show("결제 방법을 선택해 주세요");
            }
        }
    }
}
