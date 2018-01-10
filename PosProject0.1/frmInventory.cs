using System;
using System.Collections;
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

namespace PosProject0._1
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        List<InvenManage> ar = new List<InvenManage>();
        private void frmInventory_Load(object sender, EventArgs e)
        {
            
            
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("InvenManage", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataSet ds = new DataSet();
                    adapter.SelectCommand = cmd;

                    adapter.Fill(ds);
                    //DataGridViewCheckBoxColumn checkBox = new DataGridViewCheckBoxColumn();
                    dataGridView2.Columns.Add("선택", "선택");
                    
                    dataGridView2.DataSource = ds.Tables[0];

                    
                    //dataGridView2.Columns[6].DisplayIndex = 0;
                    
                    //dataGridView2.Columns[6].HeaderText = "선택";
                    //for (int i = 0; i < dataGridView2.Columns.Count - 1; i++)
                    //{
                    //    dataGridView2.Columns[i].ReadOnly = true;
                    //}
                    dataGridView2.AllowUserToAddRows = false;

                   



                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
            //clsVirtualKB.Open();
            textBox1.Focus();
        }

        

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
