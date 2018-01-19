﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static PosProject0._1.Form1;

namespace PosProject0._1
{
    public partial class frmPrefer : Form
    {
        SqlDataAdapter adapter;
        DataSet ds;
        public frmPrefer()
        {
            InitializeComponent();
        }

        private void frmPrefer_Load(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("Preferences", con))
                {
                    adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;
                    ds = new DataSet();
                    adapter.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            tboxSName.Text = row["StoreName"].ToString();
                            tboxSAddr.Text = row["StoreAddr"].ToString();
                            tboxBNum.Text = row["BusinNum"].ToString();
                            tboxSTel.Text = row["TelePhone"].ToString();
                        }
                    }
                }
            }
        }//폼로드 
        private void btnModi_Click(object sender, EventArgs e)
        {
            using (var con = new Connector().getInstance())
            {
                using (var cmd = new SqlCommand("UpdateStore",con))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@StoreName", tboxSName.Text);
                        cmd.Parameters.AddWithValue("@StoreAddr", tboxSAddr.Text);
                        cmd.Parameters.AddWithValue("@TelePhone", tboxSTel.Text);
                        cmd.Parameters.AddWithValue("@BusinNum", int.Parse(tboxBNum.Text));
                        adapter.UpdateCommand = con.CreateCommand();
                        adapter.UpdateCommand = cmd;
                        adapter.UpdateCommand.ExecuteNonQuery();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("사업자번호는 숫자를 입력해주세요","알림",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                this.Close();
            }
        }//환경설정 수정//예외처리
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
