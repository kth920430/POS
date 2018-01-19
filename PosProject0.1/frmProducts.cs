using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        byte[] bImg = null;
        string Img = null;
        public frmProducts()
        {
            InitializeComponent();
        }
        private bool CheckProduct()
        {
            if (tboxBarcode.Text == "" || tboxProName.Text == "" || tboxProprice.Text == "" ||tboxPurchase.Text == "" || cboxCat.Text == "" || cboxEve.Text == "" || cboxSup.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }//모두 작성-
        private bool Barcode()
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("CheckProduct", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Barcode", tboxBarcode.Text);
                        var sdr = cmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            MessageBox.Show("중복되는 상품이 있습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Empty();
                            sdr.Close();
                            con.Close();
                            return false;
                        }
                        else
                        {
                            sdr.Close();
                            return true;
                        }
                    }
                    catch (SqlException)
                    {
                        throw;
                    }
                }
            }
        }//바코드 중복//예외처리
        private void ProductLoad()
        {
            ProductView.AllowUserToAddRows = false;
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("ProductsLoad", con))
                {
                    try
                    {
                        adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        ds = new DataSet();
                        adapter.Fill(ds);
                        ProductView.DataSource = ds.Tables[0];
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    #region ProView
                    this.ProductView.Columns["ProNum"].Visible = false;
                    ProductView.Columns[0].HeaderText = "번호";
                    ProductView.Columns[1].HeaderText = "바코드";
                    ProductView.Columns[2].HeaderText = "상품명";
                    ProductView.Columns[3].HeaderText = "가격";
                    ProductView.Columns[4].HeaderText = "구매비용";
                    ProductView.Columns[5].HeaderText = "종류";
                    ProductView.Columns[6].HeaderText = "이벤트";
                    ProductView.Columns[7].HeaderText = "공급회사";
                    ProductView.Columns[0].Width = 100;
                    ProductView.Columns[1].Width = 140;
                    ProductView.Columns[2].Width = 180;
                    ProductView.Columns[3].Width = 140;
                    ProductView.Columns[4].Width = 140;
                    ProductView.Columns[5].Width = 140;
                    ProductView.Columns[6].Width = 140;
                  #endregion
                }
            }
        }//예외처리
        private void LoadImg()
         {
            try
            {
                ImageConverter converter = new ImageConverter();
                bImg = (byte[])converter.ConvertTo(ProductImg.Image, typeof(byte[]));
            }
            catch (NotSupportedException)
            {

                throw;
            }
         }   //이미지로드//예외처리
        private void Empty()
        {
            ProductImg.Image = Properties.Resources.noimage;
            tboxBarcode.Text = tboxProName.Text = tboxProprice.Text = tboxPurchase.Text = cboxCat.Text = cboxEve.Text = cboxSup.Text = "";
            tboxBarcode.Focus();
        }
        private void Resets(DataSet ds)
        {
            try
            {
                ProductView.DataSource = null;
                ProductView.DataSource = ds.Tables[0];
                ProductLoad();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnImg_Click(object sender, EventArgs e)
        {
            var dlg = openFileDialog1.ShowDialog();
               if (dlg == DialogResult.OK)
                {
                   Img = openFileDialog1.FileName;
                   ProductImg.Image = new Bitmap(Img);
               }
        }//사진선택
        private void btnReset_Click(object sender, EventArgs e)
        {
            Resets(ds);
            tboxBarcodeSearch.Text = cboxCategory.Text = tboxProSearch.Text = "";
        }//새로고침 -
        private void btnCancle_Click(object sender, EventArgs e)
        {
            Empty();
        }//취소 -
        private void Parameter(SqlCommand cmd)
        {
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProName", tboxProName.Text.Trim().Replace(" ", ""));
                cmd.Parameters.AddWithValue("@Barcode", tboxBarcode.Text);
                cmd.Parameters.AddWithValue("@UnitPrice", int.Parse(tboxProprice.Text));
                cmd.Parameters.AddWithValue("@PurchaseCost", int.Parse(tboxPurchase.Text));
                cmd.Parameters.AddWithValue("@CatName", cboxCat.Text);
                cmd.Parameters.AddWithValue("@EveName", cboxEve.Text);
                cmd.Parameters.AddWithValue("@SupName", cboxSup.Text);
                cmd.Parameters.AddWithValue("@ProImg", bImg);
            }
            catch (FormatException)
            {
                MessageBox.Show("가격,구매비용은 숫자를 입력해 주세요.","알림",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }//속성//예외처리
        private void frmProducts_Load(object sender, EventArgs e)
        {
            ProductLoad();
            //clsVirtualKB.Open();
            #region 상품종류
            cboxCat.Items.Add("술");
            cboxCat.Items.Add("아이스크림");
            cboxCat.Items.Add("음료");
            cboxCat.Items.Add("과자");
            cboxCat.Items.Add("라면");
            cboxCat.Items.Add("도시락");
            cboxCat.Items.Add("우유");
            cboxCat.Items.Add("비닐봉투"); 
            #endregion
            #region 상품종류2
            cboxCategory.Items.Add("술");
            cboxCategory.Items.Add("아이스크림");
            cboxCategory.Items.Add("음료");
            cboxCategory.Items.Add("과자");
            cboxCategory.Items.Add("라면");
            cboxCategory.Items.Add("도시락");
            cboxCategory.Items.Add("우유"); 
            #endregion
            #region 이벤트
            cboxEve.Items.Add("1+1 행사상품");
            cboxEve.Items.Add("2+1 행사상품");
            cboxEve.Items.Add("일반 상품"); 
            #endregion
            #region 공급업체
            cboxSup.Items.Add("LOTTE");
            cboxSup.Items.Add("동서식품");
            cboxSup.Items.Add("삼양식품");
            cboxSup.Items.Add("오리온");
            cboxSup.Items.Add("해테");
            cboxSup.Items.Add("비닐봉투");
            cboxSup.Items.Add("농심");
            #endregion
            ProductImg.Image = Properties.Resources.noimage;
        }//폼로드
        private void btnProAdd_Click(object sender, EventArgs e)
        {
            if (CheckProduct() && Barcode())
            {
                pro = ds.Tables[0];
                products = pro.NewRow();
                pro.Rows.Add(products);
                LoadImg();
                using (var con = new Connector().getInstance())
                {
                    using (var cmd = new SqlCommand("SaveProduct", con))
                    {
                        try
                        {
                            Parameter(cmd);
                            adapter.InsertCommand = cmd;
                            adapter.Update(ds);
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("데이터가 유효하지 않아 상품 저장을 실패 하였습니다.","알림",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    Resets(ds);
                }
                Empty();
            }
            else
            {
                Empty();
                return;
            }

        }//상품등록//예외처리

        private void btnProDel_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("ProductDelete", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Barcode", tboxBarcode.Text);
                        adapter.DeleteCommand = con.CreateCommand();
                        adapter.DeleteCommand = cmd;
                        adapter.DeleteCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {

                    }
                }
                Resets(ds);
            }
            Empty();
        }//상품삭제//예외처리
        private void btnProModi_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("UpdateProduct", con))
                {
                    LoadImg();
                    try
                    {
                        Parameter(cmd);
                        adapter.UpdateCommand = con.CreateCommand();
                        adapter.UpdateCommand = cmd;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("가격,구매비용은 숫자를 입력해주세요","알림",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                Resets(ds);
            }
            Empty();
        }//상품수정//예외처리

        private void tboxProSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ProductView.RowCount; i++)
                {
                    bool cell = ProductView.Rows[i].Cells[2].Value.ToString().ToUpper().Contains(tboxProSearch.Text.ToUpper().Trim());
                    if (!cell)
                    {

                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[ProductView.DataSource];
                        currencyManager1.SuspendBinding();
                        ProductView.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    else if (cell)
                    {

                        ProductView.Rows[i].Visible = true;
                    }
                    else if (tboxProSearch.Text == null)
                    {
                        ProductView.Rows[i].Visible = true;
                    }
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }

        }//상품명으로 검색//예외처리
        private void tboxBarcodeSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ProductView.RowCount; i++)
                {
                    bool cell = ProductView.Rows[i].Cells[1].Value.ToString().ToUpper().Contains(tboxBarcodeSearch.Text.ToUpper().Trim());
                    if (!cell)
                    {

                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[ProductView.DataSource];
                        currencyManager1.SuspendBinding();
                        ProductView.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    else if (cell)
                    {

                        ProductView.Rows[i].Visible = true;
                    }
                    else if (tboxBarcodeSearch.Text == null)
                    {
                        ProductView.Rows[i].Visible = true;
                    }
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }//바코드 검색//예외처리
        private void cboxCategory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < ProductView.RowCount; i++)
                {
                    bool cell = ProductView.Rows[i].Cells[5].Value.ToString().ToUpper().Contains(cboxCategory.Text.ToUpper().Trim());
                    if (!cell)
                    {

                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[ProductView.DataSource];
                        currencyManager1.SuspendBinding();
                        ProductView.Rows[i].Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                    else if (cell)
                    {

                        ProductView.Rows[i].Visible = true;
                    }
                    else if (cboxCategory.Text == null)
                    {
                        ProductView.Rows[i].Visible = true;
                    }
                }
            }
            catch (InvalidOperationException)
            {
                throw;
            }
        }//상품종류 검색//예외처리  

        private void ProductView_Click(object sender, EventArgs e)
        {
            try
            {
                tboxBarcode.Text = ProductView.CurrentRow.Cells[1].Value.ToString();
                tboxProName.Text = ProductView.CurrentRow.Cells[2].Value.ToString();
                tboxProprice.Text = ProductView.CurrentRow.Cells[3].Value.ToString();
                tboxPurchase.Text = ProductView.CurrentRow.Cells[4].Value.ToString();
                cboxCat.Text = ProductView.CurrentRow.Cells[5].Value.ToString();
                cboxEve.Text = ProductView.CurrentRow.Cells[6].Value.ToString();
                cboxSup.Text = ProductView.CurrentRow.Cells[7].Value.ToString();
            }
            catch (NullReferenceException)
            {

            }

            #region IMG
            //이미지 할 시
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("ProductImg", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ProName", tboxProName.Text);
                    var sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            if (sdr["ProImg"] != null)
                            {
                                try
                                {
                                    byte[] img = (byte[])sdr["ProImg"];
                                    ProductImg.Image = new Bitmap(new MemoryStream(img));
                                }
                                catch (Exception)
                                {
                                    ProductImg.Image = null;
                                }
                            }

                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            #endregion
        }//데이터 클릭시 나타남//예외처리
        private void ProductView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             try
            {
              ProductView.BeginEdit(true);
            }
             catch (Exception)
             {

             throw;
            }
        }//데이터 클릭시 나타남//예외처리
       
    }
}
