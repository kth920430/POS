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
        DataSet datass = null;
        DataTable dt,dt2;
        DataTable dtOrder;
        private void frmInventory_Load(object sender, EventArgs e)
        {
            
            LoadView();
            OrderList();
        }

        private void LoadView()
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
        }

        internal void OrderList()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
            for (int i = 1; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].ReadOnly = true;

            }
            
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("OrderListTable", con))
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
                        dataGridView1.Rows[n].Cells[6].Value = item[6].ToString();
                        dataGridView1.Rows[n].Cells[7].Value = item[7].ToString();
                        dataGridView1.Rows[n].Cells[8].Value = item[8].ToString();
                        dataGridView1.Rows[n].Cells[9].Value = item[9].ToString();


                    }
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1.Rows[i].Height =30;
                        dataGridView1.Rows[i].Cells[0].Value = false;
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //for (int i = 0; i < dataGridView1.RowCount; i++)
            //{
                
            //    if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
            //    {
                    using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
                    {
                        con.Open();
                        for (int j = 0; j < dataGridView1.RowCount; j++)
                        {
                            if ((bool)dataGridView1.Rows[j].Cells[0].Value == true)
                            {
                                using (var cmd = new SqlCommand("AddInvenCnt", con))
                                {

                                    cmd.CommandType = CommandType.StoredProcedure;
                                    cmd.Parameters.AddWithValue("@odernum", dataGridView1.Rows[j].Cells[1].Value.ToString());
                                    int k = cmd.ExecuteNonQuery();
                                    if (k == 1)
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
                //    }

                //}
            }
            MessageBox.Show("재고 수량이 추가 되었습니다.");
            dataGridView2.Rows.Clear(); //그리드뷰 초기화하
            tcInven1.SelectedTab = tcInven1.TabPages[0];
            LoadView(); //그리드뷰 수량증가값 보여주기
            DeleteOrderList();//발주신청목록에서 입고완료된 상품 제거하기
            
        }

        private void DeleteOrderList()
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    if ((bool)dataGridView1.Rows[j].Cells[0].Value == true)
                    {
                        using (var cmd = new SqlCommand("DeleteOrderList", con))
                        {

                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@ordernum", dataGridView1.Rows[j].Cells[1].Value.ToString());
                            int k = cmd.ExecuteNonQuery();
                            if (k == 1)
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
            }
            OrderList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
            //clsVirtualKB.Open();
            //textBox1.Focus();
            try
            {
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
                dataGridView2.BeginEdit(true);
                //dataGridView2_CellClick(null, new DataGridViewCellEventArgs(3, rowindex));

            }
            catch (FormatException)
            {
                MessageBox.Show("숫자를 입력해주세요");
                return;
            }
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Allselect();//전체선택
        }

        private void Allselect()
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

                    newRow[0] = dataGridView2.Rows[i].Cells[1].Value.ToString();
                    newRow[1] = dataGridView2.Rows[i].Cells[6].Value.ToString();
                    newRow[2] = dataGridView2.Rows[i].Cells[5].Value.ToString();
                    newRow[3] = 0;
                    dt2.Rows.Add(newRow);
                }
                
                //    tcInven1.SelectedTab = tcInven1.TabPages[1];
            }
           

            Form2 f2 = new Form2(dt2);
            f2.Owner = this;
            f2.ShowDialog();
           
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tcInven1.SelectedTab = tcInven1.TabPages[1];
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (is_Check)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = false;
                }
                is_Check = false;
            }
            else if (is_Check == false)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = true;
                }
                is_Check = true;
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    dataGridView1.Rows[i].Selected = true;
                }
                else if ((bool)dataGridView1.Rows[i].Cells[0].Value == false)
                {
                    dataGridView1.Rows[i].Selected = false;
                }
            }
        }

   

        private void button7_Click(object sender, EventArgs e)
        {

            
            button2.Show();
            button7.Hide();

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                //if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == Convert.ToChar(Keys.Enter)))
                //{
                //    e.Handled = true;
                //    MessageBox.Show("숫자만입력해주세요");
                //}
                //if (int.Parse(textBox6.Text) > 100)
                //{
                //    MessageBox.Show("숫자가 너무 큽니다.");
                //    textBox6.Text = "0";
                //}
                if (int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString()) < 0)
                {
                    MessageBox.Show("수량은 (-)가 될수 없습니다.");
                    return;
                }
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
