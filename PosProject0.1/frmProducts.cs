using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PosProject0._1.Form1;

namespace PosProject0._1
{
    public partial class frmProducts : Form
    {
        DataSet ds;
        SqlDataAdapter adapter;
        DataTable pro;
        DataRow products;
        //byte[] bImg = null;
        //string Img = null;
        
        private bool CheckProduct()
        {
            if (tboxBarcode.Text == "" || tboxProName.Text == "" || tboxProprice.Text == "" || 
                tboxPurchase.Text == "" || cboxCat.Text == "" || cboxEve.Text == "" || cboxSup.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }//모두 작성
        public frmProducts()
        {
            InitializeComponent();
        }
        private void ProductLoad()
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("ProductsLoad", con))
                {
                    adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                    #region ProView
                    dataGridView1.Columns[0].HeaderText = "바코드";
                    dataGridView1.Columns[1].HeaderText = "상품명";
                    dataGridView1.Columns[2].HeaderText = "상품가격";
                    dataGridView1.Columns[3].HeaderText = "구매비용";
                    dataGridView1.Columns[4].HeaderText = "종류";
                    dataGridView1.Columns[5].HeaderText = "이벤트";
                    dataGridView1.Columns[6].HeaderText = "공급회사";
                    dataGridView1.Columns[0].Width = 100;
                    dataGridView1.Columns[1].Width = 140;
                    dataGridView1.Columns[2].Width = 180;
                    dataGridView1.Columns[3].Width = 140;
                    dataGridView1.Columns[4].Width = 140;
                    dataGridView1.Columns[5].Width = 140;
                    dataGridView1.Columns[6].Width = 140;
               

                    #endregion
                }
            }
        }
        //private void LoadImg()
        //{
        //    ImageConverter converter = new ImageConverter();
        //    bImg = (byte[])converter.ConvertTo(pictureBox1.Image, typeof(byte[]));
        //}
        private void Empty()
        {
            //pictureBox1.Image = Properties.Resources.noimage;
            tboxBarcode.Text = tboxProName.Text = tboxProprice.Text = tboxPurchase.Text = cboxCat.Text = cboxEve.Text = cboxSup.Text = "";
            tboxBarcode.Focus();
        }
        private void Resets(DataSet ds)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];
            ProductLoad();
        }
        //private void btnImg_Click(object sender, EventArgs e)
        //{
        //    var dlg = openFileDialog1.ShowDialog();
        //    if (dlg == DialogResult.OK)
        //    {
        //        Img = openFileDialog1.FileName;
        //        pictureBox1.Image = new Bitmap(Img);
        //    }
        //}
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Empty();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            ProductLoad();
            //clsVirtualKB.Open();
            //종류 이벤트 공급업체 아이템 추가
            this.dataGridView1.Columns["ProNum"].Visible = false;
            cboxCat.Items.Add("술");
                cboxCat.Items.Add("아이스크림");
                cboxCat.Items.Add("음료");
                cboxCat.Items.Add("과자");
                cboxCat.Items.Add("라면");
                cboxCat.Items.Add("도시락");
                cboxCat.Items.Add("우유");
                cboxCat.Items.Add("비닐봉투");
                cboxEve.Items.Add("일반가");
                cboxEve.Items.Add("1+1 행사상품");
                cboxEve.Items.Add("2+1 행사상품");
                #region 공급업체
                cboxSup.Items.Add("LOTTE");
                cboxSup.Items.Add("동서식품");
                cboxSup.Items.Add("삼양식품");
                cboxSup.Items.Add("오리온");
                cboxSup.Items.Add("해테");
                cboxSup.Items.Add("비닐봉투");
                cboxSup.Items.Add("농심"); 
                #endregion
            //pictureBox1.Image = Properties.Resources.noimage;
        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
            tboxBarcode.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tboxProName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tboxProprice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tboxPurchase.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cboxCat.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cboxEve.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cboxSup.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            //이미지 할 시
            //using (var con = new Connector().getInstance())
            //{
            //    using (var cmd = new SqlCommand("EmpImg", con))
            //    {
            //        cmd.CommandType = CommandType.StoredProcedure;
            //        cmd.Parameters.AddWithValue("@EmpName", tboxEname.Text);
            //        var sdr = cmd.ExecuteReader();
            //        if (sdr.HasRows)
            //        {
            //            while (sdr.Read())
            //            {
            //                if (sdr["EmpImg"] != null)
            //                {
            //                    try
            //                    {
            //                        byte[] img = (byte[])sdr["EmpImg"];
            //                        pictureBox1.Image = new Bitmap(new MemoryStream(img));
            //                    }
            //                    catch (Exception)
            //                    {
            //                        pictureBox1.Image = null;
            //                    }
            //                }

            //            }
            //        }
            //        else
            //        {
            //            return;
            //        }
            //    }
            //}
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Resets(ds);
        }
        private void Parameter(SqlCommand cmd)
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProName", tboxProName.Text.Trim().Replace(" ", ""));
            cmd.Parameters.AddWithValue("@Barcode", tboxBarcode.Text);
            cmd.Parameters.AddWithValue("@UnitPrice", int.Parse(tboxProprice.Text));
            cmd.Parameters.AddWithValue("@PurchaseCost", int.Parse(tboxPurchase.Text));
            cmd.Parameters.AddWithValue("@CatName", cboxCat.Text);
            cmd.Parameters.AddWithValue("@EveName", cboxEve.Text);
            cmd.Parameters.AddWithValue("@SupName", cboxSup.Text);
            //고쳐야함
            cmd.Parameters.Add("@ProNum");
            
      
            
        }
        private void btnProAdd_Click(object sender, EventArgs e)
        {
            if (CheckProduct())
            {
                pro = ds.Tables[0];
                products = pro.NewRow();
                pro.Rows.Add(products);
                //LoadImg();
                using (var con = new Connector().getInstance())
                {
                    using (var cmd = new SqlCommand("SaveProduct", con))
                    {
                        Parameter(cmd);
                        adapter.InsertCommand = cmd;
                        adapter.Update(ds);
                    }
                    Resets(ds);
                    Empty();
                }
            }
            else
            {
                MessageBox.Show("데이터가 유효하지 않아 저장 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Empty();
                return;
            }
        }
    }
}
