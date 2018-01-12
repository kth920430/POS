﻿using System;
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
        DataSet datass = null;
        DataTable dt,dt2;
        DataTable dtOrder;
        private void frmInventory_Load(object sender, EventArgs e)
        {
            button7.Hide();
            
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
                        dataGridView2.Columns[i].ReadOnly = true;

                    }
                    
                }
            }
            OrderList(); //발주목록
        }

        private void OrderList()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("OrderTable", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.SelectCommand = cmd;
                    dtOrder = new DataTable();
                    adapter.Fill(dtOrder);

                    foreach (DataRow item in dtOrder.Rows)
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                        dataGridView1.Rows[n].Cells[1].Value = item[1].ToString();
                        dataGridView1.Rows[n].Cells[2].Value = item[2].ToString();
                        dataGridView1.Rows[n].Cells[3].Value = item[3].ToString();
                        dataGridView1.Rows[n].Cells[4].Value = item[4].ToString();
                        dataGridView1.Rows[n].Cells[5].Value = item[5].ToString();

                    }

                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
            //clsVirtualKB.Open();
            //textBox1.Focus();
            button2.Hide();
            button7.Show();
            MessageBox.Show("수량을 변경 후 완료버튼을 눌러주세요");
            int rowindex = dataGridView2.CurrentRow.Index;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                dataGridView2.Rows[i].Cells[3].ReadOnly = false;
            }
            object cell = dataGridView2.CurrentRow.Cells[3];
            dataGridView2.CurrentRow.Cells[3].Selected = true;
            dataGridView2_CellClick(null, new DataGridViewCellEventArgs(3, rowindex));
           
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

                dataGridView2.BeginEdit(true);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("상품명");
            dt2.Columns.Add("바코드");
            dt2.Columns.Add("구입가");
            dt2.Columns.Add("수량");

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if ((bool)dataGridView2.Rows[i].Cells[0].Value == true)
                {
                    DataRow newRow = dt2.NewRow();
                    textBox2.Text += dataGridView2.Rows[i].Cells[1].Value.ToString() + "\t";
                    textBox2.Text += dataGridView2.Rows[i].Cells[3].Value.ToString() + "\t";
                    textBox2.Text += dataGridView2.Rows[i].Cells[5].Value.ToString() + "\t";
                    textBox2.Text += dataGridView2.Rows[i].Cells[6].Value.ToString() + "\t";

                    newRow[0] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    newRow[1] = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    newRow[2] = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    newRow[3] = null;
                    dt2.Rows.Add(newRow);
                }
                
                //    tcInven1.SelectedTab = tcInven1.TabPages[1];
            }
           

            Form2 f2 = new Form2(dt2);
            f2.Owner = this;
            f2.ShowDialog();
            //f2.ShowDialog();
            //dt2 = dt;
            //foreach (DataRow item in dt2.Rows)
            //{
            //    int n = dataGridView2.Rows.Add();
            //    dataGridView2.Rows[n].Cells[1].Value = item[0].ToString();
            //    dataGridView2.Rows[n].Cells[2].Value = item[5].ToString();
            //    dataGridView2.Rows[n].Cells[3].Value = item[3].ToString();
            //    dataGridView2.Rows[n].Cells[4].Value = item[4].ToString();


            //}
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tcInven1.SelectedTab = tcInven1.TabPages[1];
        }

        private void button7_Click(object sender, EventArgs e)
        {

            
            button2.Show();
            button7.Hide();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
                {
                    con.Open();
                    int j;
                    using (var cmd = new SqlCommand("ChangeProCnt", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@invencount", dataGridView2.Rows[i].Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@barcode", dataGridView2.Rows[i].Cells[6].Value.ToString());
                        j = cmd.ExecuteNonQuery();
                    }
                       
                }
                dataGridView2.Rows[i].Cells[3].ReadOnly = true;
            }
            MessageBox.Show("수량이 변경되었습니다.");
            
        }
    }
}
