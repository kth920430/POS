namespace PosProject0._1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.판매등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalesMan = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잠깐외출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.dateyymmdd = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.Label();
            this.btnMaster = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 10, 0, 10);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.판매등록ToolStripMenuItem,
            this.현황ToolStripMenuItem,
            this.품목관리ToolStripMenuItem,
            this.btnSalesMan,
            this.환경설정ToolStripMenuItem,
            this.인쇄설정ToolStripMenuItem,
            this.회원ToolStripMenuItem,
            this.잠깐외출ToolStripMenuItem,
            this.btnCheckIn});
            this.menuStrip1.Location = new System.Drawing.Point(0, 109);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(177, 565);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 판매등록ToolStripMenuItem
            // 
            this.판매등록ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.판매등록ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.판매등록ToolStripMenuItem.Name = "판매등록ToolStripMenuItem";
            this.판매등록ToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.판매등록ToolStripMenuItem.Text = "상품판매";
            // 
            // 현황ToolStripMenuItem
            // 
            this.현황ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.현황ToolStripMenuItem.Name = "현황ToolStripMenuItem";
            this.현황ToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.현황ToolStripMenuItem.Text = "판매현황";
            // 
            // 품목관리ToolStripMenuItem
            // 
            this.품목관리ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.품목관리ToolStripMenuItem.Name = "품목관리ToolStripMenuItem";
            this.품목관리ToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.품목관리ToolStripMenuItem.Text = "품목관리";
            // 
            // btnSalesMan
            // 
            this.btnSalesMan.Margin = new System.Windows.Forms.Padding(10);
            this.btnSalesMan.Name = "btnSalesMan";
            this.btnSalesMan.Size = new System.Drawing.Size(144, 44);
            this.btnSalesMan.Text = "매출관리";
            this.btnSalesMan.Click += new System.EventHandler(this.btnSalesMan_Click);
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.환경설정ToolStripMenuItem.Text = "재고,발주";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // 인쇄설정ToolStripMenuItem
            // 
            this.인쇄설정ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.인쇄설정ToolStripMenuItem.Name = "인쇄설정ToolStripMenuItem";
            this.인쇄설정ToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.인쇄설정ToolStripMenuItem.Text = "환경설정";
            // 
            // 회원ToolStripMenuItem
            // 
            this.회원ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.회원ToolStripMenuItem.Name = "회원ToolStripMenuItem";
            this.회원ToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.회원ToolStripMenuItem.Text = "직원관리";
            // 
            // 잠깐외출ToolStripMenuItem
            // 
            this.잠깐외출ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.잠깐외출ToolStripMenuItem.Name = "잠깐외출ToolStripMenuItem";
            this.잠깐외출ToolStripMenuItem.Size = new System.Drawing.Size(144, 44);
            this.잠깐외출ToolStripMenuItem.Text = "잠깐외출";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(164, 44);
            this.btnCheckIn.Text = "출     근";
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // dateyymmdd
            // 
            this.dateyymmdd.AutoSize = true;
            this.dateyymmdd.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateyymmdd.Location = new System.Drawing.Point(63, 20);
            this.dateyymmdd.Name = "dateyymmdd";
            this.dateyymmdd.Size = new System.Drawing.Size(168, 27);
            this.dateyymmdd.TabIndex = 1;
            this.dateyymmdd.Text = "2018.01.08";
            // 
            // dateTime
            // 
            this.dateTime.AutoSize = true;
            this.dateTime.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTime.Location = new System.Drawing.Point(63, 60);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(146, 27);
            this.dateTime.TabIndex = 2;
            this.dateTime.Text = "10시 10분";
            // 
            // btnMaster
            // 
            this.btnMaster.Location = new System.Drawing.Point(1072, 23);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(63, 34);
            this.btnMaster.TabIndex = 5;
            this.btnMaster.Text = "관리모드";
            this.btnMaster.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1008, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "홈";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1141, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "종료하기";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.SteelBlue;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.40187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.59813F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.dateyymmdd, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMaster, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1229, 109);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 674);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateyymmdd;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label dateTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 판매등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSalesMan;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잠깐외출ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCheckIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

