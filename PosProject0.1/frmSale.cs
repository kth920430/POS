﻿using PosProject0._1;
using System;
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

namespace convenienceStorePos
{
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }
        List<clsSale> list = new List<clsSale>();
        bool rows;

        internal List<clsSale> List { get => list; set => list = value; }

        private void frmSale_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            lblDate.Text = DateTime.Now.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Location = new Point(this.ClientSize.Width / 2 - label1.Width / 2, this.ClientSize.Height / 2 - label1.Height / 2);
            lblDate.Text = DateTime.Now.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayChoice_Click(object sender, EventArgs e)
        {
            frmPayChoice fpc = new frmPayChoice();
            fpc.ShowDialog();
        }
        private void btnCode_Click(object sender, EventArgs e)
        {
            frmBarCode fbc = new frmBarCode
            {
                Owner = this
            }
            ;
            fbc.ShowDialog(this);
        }
        private void btnAddPB_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["posproject"].ConnectionString))
            {
                con.Open();
                using (var cmd = new SqlCommand("ProductsSale", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uBarCode", 0);
                    var sdr = cmd.ExecuteReader();

                    if (!sdr.HasRows)
                    {
                        MessageBox.Show("다시 한번 눌러주세요.");
                        return;
                    }
                    else
                    {
                        //봉투 버튼 클릭 시, 카운터 증가
                        if (dataGridView1.Rows.Count.ToString() == "0")
                        {
                            while (sdr.Read())
                            {
                                List.Add(new clsSale()
                                {
                                    ProNum = int.Parse(sdr["ProNum"].ToString()),
                                    ProName = sdr["ProName"].ToString(),
                                    ProCount = 1,
                                    UnitPrice = int.Parse(sdr["UnitPrice"].ToString()),
                                    Discount = 0
                                });
                            }
                        }
                        else
                        {
                            //검색만해서 있으면 true 없으면 false
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {

                                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "100")
                                {
                                    rows = false;
                                    while (sdr.Read())
                                    {
                                        if (rows == false)
                                        {
                                            dataGridView1.Rows[i].Cells[2].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) + 1;
                                            dataGridView1.Rows[i].Cells[3].Value = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()) * 20;
                                        }
                                    }
                                }
                                else
                                {
                                    rows = true;
                                }
                            }
                            if (rows == true)
                            {
                                while (sdr.Read())
                                {
                                    List.Add(new clsSale()
                                    {
                                        ProNum = int.Parse(sdr["ProNum"].ToString()),
                                        ProName = sdr["ProName"].ToString(),
                                        ProCount = 1,
                                        UnitPrice = int.Parse(sdr["UnitPrice"].ToString()),
                                        Discount = 0
                                    });
                                }
                            }
                        }
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = List;
                        sdr.Close();
                    }

                }
                // MessageBox.Show(rows.ToString());
            }

            dataGridView1.Columns[0].HeaderText = "상품 번호";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].HeaderText = "상 품 명";
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].HeaderText = "수 량";
            dataGridView1.Columns[3].HeaderText = "단 가";
            dataGridView1.Columns[4].HeaderText = "할 인";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            list.Clear();
            dataGridView1.DataSource = null;
        }
    }
}
