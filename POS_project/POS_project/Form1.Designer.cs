namespace POS_project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.판매등록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현황ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.품목관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자료관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잠깐외출ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 10, 0, 10);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.판매등록ToolStripMenuItem,
            this.현황ToolStripMenuItem,
            this.품목관리ToolStripMenuItem,
            this.자료관리ToolStripMenuItem,
            this.환경설정ToolStripMenuItem,
            this.인쇄설정ToolStripMenuItem,
            this.회원ToolStripMenuItem,
            this.잠깐외출ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 107);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(150, 0, 150, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(171, 693);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 판매등록ToolStripMenuItem
            // 
            this.판매등록ToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.판매등록ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.판매등록ToolStripMenuItem.Name = "판매등록ToolStripMenuItem";
            this.판매등록ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.판매등록ToolStripMenuItem.Text = "상품판매";
            this.판매등록ToolStripMenuItem.Click += new System.EventHandler(this.판매등록ToolStripMenuItem_Click);
            // 
            // 현황ToolStripMenuItem
            // 
            this.현황ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.현황ToolStripMenuItem.Name = "현황ToolStripMenuItem";
            this.현황ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.현황ToolStripMenuItem.Text = "판매현황";
            this.현황ToolStripMenuItem.Click += new System.EventHandler(this.현황ToolStripMenuItem_Click);
            // 
            // 품목관리ToolStripMenuItem
            // 
            this.품목관리ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.품목관리ToolStripMenuItem.Name = "품목관리ToolStripMenuItem";
            this.품목관리ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.품목관리ToolStripMenuItem.Text = "품목관리";
            this.품목관리ToolStripMenuItem.Click += new System.EventHandler(this.품목관리ToolStripMenuItem_Click);
            // 
            // 자료관리ToolStripMenuItem
            // 
            this.자료관리ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.자료관리ToolStripMenuItem.Name = "자료관리ToolStripMenuItem";
            this.자료관리ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.자료관리ToolStripMenuItem.Text = "매출관리";
            this.자료관리ToolStripMenuItem.Click += new System.EventHandler(this.자료관리ToolStripMenuItem_Click);
            // 
            // 환경설정ToolStripMenuItem
            // 
            this.환경설정ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.환경설정ToolStripMenuItem.Name = "환경설정ToolStripMenuItem";
            this.환경설정ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.환경설정ToolStripMenuItem.Text = "재고관리";
            this.환경설정ToolStripMenuItem.Click += new System.EventHandler(this.환경설정ToolStripMenuItem_Click);
            // 
            // 인쇄설정ToolStripMenuItem
            // 
            this.인쇄설정ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.인쇄설정ToolStripMenuItem.Name = "인쇄설정ToolStripMenuItem";
            this.인쇄설정ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.인쇄설정ToolStripMenuItem.Text = "환경설정";
            // 
            // 회원ToolStripMenuItem
            // 
            this.회원ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.회원ToolStripMenuItem.Name = "회원ToolStripMenuItem";
            this.회원ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.회원ToolStripMenuItem.Text = "직원관리";
            this.회원ToolStripMenuItem.Click += new System.EventHandler(this.회원ToolStripMenuItem_Click);
            // 
            // 잠깐외출ToolStripMenuItem
            // 
            this.잠깐외출ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10);
            this.잠깐외출ToolStripMenuItem.Name = "잠깐외출ToolStripMenuItem";
            this.잠깐외출ToolStripMenuItem.Size = new System.Drawing.Size(138, 44);
            this.잠깐외출ToolStripMenuItem.Text = "잠깐외출";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "상품 판매";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(191, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "시간";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1940, 107);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(686, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "사 용 자 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SteelBlue;
            this.label4.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(680, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "근무시간 :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1797, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 107);
            this.button1.TabIndex = 6;
            this.button1.Text = "시스템종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(833, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "홍길동(관리자)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(833, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "00:30";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 800);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 판매등록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현황ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 품목관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자료관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잠깐외출ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

