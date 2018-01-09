using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            ar.Add(new InvenManage { InvenNum = 1, ProName = "프렌치카페 로스터리", InvenCount = 5, PurchaseCost = 2500});
            ar.Add(new InvenManage { InvenNum = 2, ProName = "덴마크 갤러리까페", InvenCount = 2, PurchaseCost = 2200 });
            ar.Add(new InvenManage { InvenNum = 3, ProName = "테이크 얼라이브", InvenCount = 10, PurchaseCost = 1700 });

            dataGridView1.DataSource = ar;
            //DataGridViewCheckBoxColumn dgvcheck = new DataGridViewCheckBoxColumn();
            //dgvcheck.HeaderText = "체크";
            //dgvcheck.Name = "check";
            //dgvcheck.DisplayIndex = 0;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int intchange;

            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    // 모든 행의 CheckBox값을 False로 설정
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        dataGridView1[4, i].Value = false; // 6은 CheckBox가 있는 열 번호
                    }
                    // 현재 선택된 행의 CheckBox값을 True로 설정
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        //Convert.ToInt32 => string을 int로 변환
                        intchange = Convert.ToInt32(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                        dataGridView1[4, intchange].Value = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        bool clickCount = false;

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //첫번째 컬럼(선택)이면
            if (e.ColumnIndex > -1 && e.ColumnIndex == 0)
            {
                //false면 컬럼헤더 클릭시 전체선택
                if (clickCount == false)
                {
                    //그리드뷰 행갯수만큼 루프돌면서 unchecked면 checked로.
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if ((int)dataGridView1.Rows[i].Cells[0].Value == 0)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = 1;
                        }
                    }
                    clickCount = true; //다음번 컬럼헤더 클릭시 전체해제를 위해 true로 설정.
                }
                else
                {
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        if ((int)dataGridView1.Rows[i].Cells[0].Value == 1)
                        {
                            dataGridView1.Rows[i].Cells[0].Value = 0;
                        }
                    }
                    clickCount = false;
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clsVirtualKB.Open();
            textBox1.Focus();
        }
    }
}
