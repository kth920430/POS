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
    public partial class frmCategory : Form
    {
        
        SqlDataAdapter adapter;
        DataTable cat;
        DataRow categorys;
        DataSet ds;
        frmProducts fp = new frmProducts();
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
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CatNum", int.Parse(tboxCatNum.Text));
                    cmd.Parameters.AddWithValue("@CatName", tboxCatName.Text);
                    adapter.InsertCommand = cmd;
                   
                    adapter.Update(ds);
                    
                }
            }
            Empty();
         
        }
    }
}
