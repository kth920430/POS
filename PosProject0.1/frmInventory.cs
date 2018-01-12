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
        bool is_Check = false;
        public frmInventory()
        {
            InitializeComponent();
        }
        
        List<InvenManage> ar = new List<InvenManage>();
        DataTable dt;
        private void frmInventory_Load(object sender, EventArgs e)
        {
            
            
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("InvenManage", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand = cmd;
                    dt = new DataTable();
                    adapter.Fill(dt);

                    foreach (DataRow item in dt.Rows)
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = false;
                        dataGridView2.Rows[n].Cells[1].Value = item[0].ToString();
                        dataGridView2.Rows[n].Cells[2].Value = item[1].ToString();
                        dataGridView2.Rows[n].Cells[3].Value = item[2].ToString();
                        dataGridView2.Rows[n].Cells[4].Value = item[3].ToString();
                        dataGridView2.Rows[n].Cells[5].Value = item[4].ToString();
                        dataGridView2.Rows[n].Cells[6].Value = item[5].ToString();


                    }
                    dataGridView2.Columns[0].Width = 50;
                    dataGridView2.Columns[1].Width = 500;
                    dataGridView2.AllowUserToAddRows = false; // 맨마지막행 안보이게하기
                    //크기조절
                    for (int i = 0; i < dataGridView2.RowCount; i++)
                    {
                        dataGridView2.Rows[i].Height = 30;
                        if (int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()) <= 5)
                        {
                            dataGridView2.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        }
                    }
                    // 선택열 빼고 나머지는 리드온리로.
                    for (int i = 1; i < dataGridView2.ColumnCount; i++)
                    {
                        dataGridView2.Columns[i].ReadOnly = false;
                        
                    }
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
            //clsVirtualKB.Open();
            textBox1.Focus();
        }

        

       

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Cells[3].ReadOnly = false;
                
            }
            //dataGridView2.Rows[3].Cells[3].Selected = true;
            //dataGridView2.Focus();
            dataGridView2.CurrentRow.Cells[3].Selected = true;
            //dataGridView2.CurrentRow.Cells[3].mode
        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            if (is_Check)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Cells[0].Value = false;
                }
                is_Check = false;
            }
            else if (is_Check == false)
            {
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    dataGridView2.Rows[i].Cells[0].Value = true;
                }
                is_Check = true;
            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].Value == true)
                {
                    dataGridView2.Rows[i].Selected = true;
                }
                else if ((bool)dataGridView2.Rows[i].Cells[0].Value == false)
                {
                    dataGridView2.Rows[i].Selected = false;
                }
            }
        }

        private void dataGridView2_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            //MessageBox.Show(sender.ToString());
            //for (int i = 0; i < dataGridView2.RowCount; i++)
            //{
            //    dataGridView2.Rows[i].Cells[0].Value = true;
            //}
            //dataGridView2.Rows[0].Cells[0].Value = true;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {          
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].Value == true)
                {
                    //dataGridView2.Rows[i].Cells[i].Selected = true;
                    for (int y = 0; y < dataGridView2.ColumnCount; y++)
                    {
                        dataGridView2.Rows[i].Cells[y].Style.BackColor = Color.Yellow;
                        if (int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()) <= 5)
                        {                      
                            dataGridView2.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        }                       
                    }
                }
                else
                {
                    for (int y = 0; y < dataGridView2.ColumnCount; y++)
                    {
                        dataGridView2.Rows[i].Cells[y].Style.BackColor = Color.White;
                        if (int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()) <= 5)
                        {
                            dataGridView2.Rows[i].Cells[3].Style.BackColor = Color.Red;
                        }
                    }
                }

                
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            //DataTable ds3 = (DataTable)dataGridView2.DataSource;
            //foreach (DataRow item in ds3.Rows)
            //{
            //    if (item[0].ToString() == "true")
            //    {
            //        dt2.ImportRow(item);
            //    }
            //}
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].Value == true)
                {
                    textBox1.Text += dataGridView2.Rows[i].Cells[1].Value.ToString();
                }
                tcInven1.SelectedTab = tcInven1.TabPages[1];
            }

            //Form2 f2 = new Form2(dt2);
            //f2.ShowDialog();
            //발주페이지이동
            //if (MessageBox.Show("선택한 품목에 대해 발주신청을 하시겠습니까?", "발주신청", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            //{
            //    MessageBox.Show("Test");
            //    tcInven1.SelectedTab = tcInven1.TabPages[1];
            //}
        }
    }
}
