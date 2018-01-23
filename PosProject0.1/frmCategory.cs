using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static PosProject0._1.Form1;

namespace PosProject0._1
{
    public partial class frmCategory : Form
    {
        SqlDataAdapter adapter;
        DataTable cat;
        DataRow categorys;
        DataSet ds;
        public frmCategory()
        {
            InitializeComponent();
        }
        private void Empty()
        {
            tboxCatNum.Text = tboxCatName.Text = "";
            tboxCatNum.Focus();
        }
        private void Resets(DataSet ds)
        {
            try
            {
                CategoryView.DataSource = null;
                CategoryView.DataSource = ds.Tables[0];
                CategoryLoad();
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void CategoryLoad()
        {
           
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("CategoryLoad", con))
                {

                    try
                    {
                        adapter = new SqlDataAdapter();
                        adapter.SelectCommand = cmd;
                        ds = new DataSet();
                        adapter.Fill(ds);
                        CategoryView.DataSource = ds.Tables[0];

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    //this.CategoryView.Columns["CatNum"].Visible = false;
                    CategoryView.Columns[0].HeaderText = "번호";
                    CategoryView.Columns[1].HeaderText = "이름";
                    CategoryView.Columns[0].Width = 70;
                }
            }
        }
        private void frmCategory_Load(object sender, EventArgs e)
        {
            CategoryView.AllowUserToAddRows = false;
            CategoryLoad();
        }
        private void btnCatAdd_Click_1(object sender, EventArgs e)
        {
            cat = ds.Tables[0];
            categorys = cat.NewRow();
            cat.Rows.Add(categorys);
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("SaveCategory", con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CatNum", int.Parse(tboxCatNum.Text));
                        cmd.Parameters.AddWithValue("@CatName", tboxCatName.Text);
                        adapter.InsertCommand = cmd;
                        adapter.Update(ds);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("데이터가 유효하지 않아 카테고리 저장을 실패 하였습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Resets(ds);
            }
            Empty();
            this.Close();
        }
        private void btnCatDel_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("DeleteCategory", con))
                {

                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@CatName", tboxCatName.Text);
                        adapter.DeleteCommand = con.CreateCommand();
                        adapter.DeleteCommand = cmd;
                        adapter.DeleteCommand.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {

                        throw;
                    }
                }
                Resets(ds);
            }
            Empty();
            this.Close();
        }
        private void CategoryView_Click(object sender, EventArgs e)
        {
            try
            {
                tboxCatNum.Text = CategoryView.CurrentRow.Cells[0].Value.ToString();
                tboxCatName.Text = CategoryView.CurrentRow.Cells[1].Value.ToString();
            }
            catch (NullReferenceException)
            {

                throw;
            }
        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
