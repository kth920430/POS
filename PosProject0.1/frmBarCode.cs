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
        bool rows;
        int rowsNum;

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm = Owner as frmSale;

            List<clsSale> list = frm.List;
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
                        //봉투 버튼 클릭 시, 카운터 증가
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
                                    Discount = 0
                                });
                            }
                            
                            sdr.Close();

                        }
                        else
                        {
                            //검색만해서 있으면 true 없으면 false
                            for (int i = 0; i < ((frmSale)(this.Owner)).dataGridView1.Rows.Count; i++)
                            {
                                MessageBox.Show(sdr["ProNum"].ToString());
                                if (((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[0].Value.ToString() == sdr["ProNum"].ToString())
                                {
                                    rows = false;

                                    while (sdr.Read())
                                    {
                                        if (rows == false)
                                        {
                                            ((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value = int.Parse(((frmSale)(this.Owner)).dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;

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
                                    list.Add(new clsSale()
                                    {
                                        ProNum = int.Parse(sdr["ProNum"].ToString()),
                                        ProName = sdr["ProName"].ToString(),
                                        ProCount = 1,
                                        UnitPrice = int.Parse(sdr["UnitPrice"].ToString()),
                                        Discount = 0
                                    });
                                }
                            }
                            sdr.Close();
                        }
                        ((frmSale)(this.Owner)).dataGridView1.DataSource = null;
                        ((frmSale)(this.Owner)).dataGridView1.DataSource = list;
                        sdr.Close();
                    }
                }

            }
            ((frmSale)(this.Owner)).dataGridView1.Columns[0].HeaderText = "상품 번호";
            ((frmSale)(this.Owner)).dataGridView1.Columns[1].Width = 150;
            ((frmSale)(this.Owner)).dataGridView1.Columns[1].HeaderText = "상 품 명";
            ((frmSale)(this.Owner)).dataGridView1.Columns[1].Width = 300;
            ((frmSale)(this.Owner)).dataGridView1.Columns[2].HeaderText = "수 량";
            ((frmSale)(this.Owner)).dataGridView1.Columns[3].HeaderText = "단 가";
            ((frmSale)(this.Owner)).dataGridView1.Columns[4].HeaderText = "할 인";

            txtbarCode.Text = null;
        }
    }
}

