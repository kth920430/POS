using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                dgv.Rows[i].Cells[0].Value = 0;
            }

            button4.Text = "선택품목\r\n발주신청";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < dgv.RowCount)
            {
                //object형를 int형으로 형변환후 unchecked면 checked로.
                if ((int)dgv.Rows[e.RowIndex].Cells[0].Value == 0)
                {
                    dgv.Rows[e.RowIndex].Cells[0].Value = 1; //checked
                }

                else
                {
                    dgv.Rows[e.RowIndex].Cells[0].Value = 0; //unchecked       
                }
            }

        }
        bool clickCount = false; // 전체선택/해제를 위한 변수

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //첫번째 컬럼(선택)이면
            if (e.ColumnIndex > -1 && e.ColumnIndex == 0)
            {
                //false면 컬럼헤더 클릭시 전체선택
                if (clickCount == false)
                {
                    //그리드뷰 행갯수만큼 루프돌면서 unchecked면 checked로.
                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        if ((int)dgv.Rows[i].Cells[0].Value == 0)
                        {
                            dgv.Rows[i].Cells[0].Value = 1;
                        }
                    }
                    clickCount = true; //다음번 컬럼헤더 클릭시 전체해제를 위해 true로 설정.
                }
                else
                {
                    for (int i = 0; i < dgv.RowCount; i++)
                    {
                        if ((int)dgv.Rows[i].Cells[0].Value == 1)
                        {
                            dgv.Rows[i].Cells[0].Value = 0;
                        }
                    }
                    clickCount = false;
                }
            }

        }
    }
}
