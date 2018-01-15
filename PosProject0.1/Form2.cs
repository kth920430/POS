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
    public partial class Form2 : Form
    {
        DataTable orderitem;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(DataTable dt) : this()
        {
            //this.ds = ds;

            //friendsTable = ds.Tables[0];
            //DataRowCollection rows = friendsTable.Rows;

            orderitem = dt;

            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            int cnt = 0;
            dataGridView1.AllowUserToAddRows = false;
            order();
            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    dataGridView1.Rows[i].Cells[3].Value = cnt;
            //}
        }

        private void order()
        {
            
            dataGridView1.DataSource = orderitem;
            dataGridView1.Columns[0].Width = 200;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("선택한 품목에 대해 발주신청을 하시겠습니까?", "발주신청", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1.Rows[i].Cells[3].Value.ToString() == "0" || dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("수량을 적어주세요");
                        return;
                    }
                }
                this.Hide();
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
                {
                    con.Open();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        using (var cmd = new SqlCommand("SaveOrderList", con))
                        {
                        
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@barcord", dataGridView1.Rows[i].Cells[1].Value.ToString());
                            cmd.Parameters.AddWithValue("@ordercount", int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()));
                            int j = cmd.ExecuteNonQuery();
                            if (j == 1)
                            {

                                
                            }
                            else
                            {
                                MessageBox.Show("Test");
                                return;
                            }
                        }
                    }
                }

                frmInventory fi = (frmInventory)Owner;
                fi.tcInven1.SelectedTab = fi.tcInven1.TabPages[1];
                fi.OrderList();
                //tcInven1.SelectedTab = tcInven1.TabPages[1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int price = 0;
            //int cnt = 0;
            //int sum = 0;
            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
            //    dataGridView1.Rows[i].Cells[0].ReadOnly = true;
            //    sum += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
            //}
            //label2.Text = sum.ToString();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].ReadOnly = true;
                    sum += int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                label2.Text = SumValue(sum).ToString() + "원";
            }
            catch (OverflowException)
            {
                MessageBox.Show("발주량이 너무 많습니다.");
                dataGridView1.CurrentRow.Cells[3].Value = 0;
                
            }
            
        }

        private object SumValue(int sum) //합계금액 정규표현식
        {
            return string.Format("{0:#,###}", sum);
        }
    }
}
