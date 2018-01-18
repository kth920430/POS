using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PosProject0._1
{
    public partial class SalesStatus : Form
    {
        public SalesStatus()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void SalesStatus_Load(object sender, EventArgs e)
        {
            LoadGridView("SaleStatusDD");
        }

        private void LoadGridView(string querry)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand(querry, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    salesStatusGrid.DataSource = dt;

                }
            }
        }

        private void selectYMD_SelectedIndexChanged(object sender, EventArgs e)
        {
            salesStatusGrid.Rows.Clear();
            switch (selectYMD.SelectedIndex)
            {
                case 0:
                    {
                        LoadGridView("SaleStatusDD");
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
