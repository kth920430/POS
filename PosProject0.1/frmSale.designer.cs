namespace convenienceStorePos
{
    partial class frmSale
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCode = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPayChoice = new System.Windows.Forms.Button();
            this.btnDC = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSumdis = new System.Windows.Forms.Label();
            this.lblSummoney = new System.Windows.Forms.Label();
            this.lblSumcount = new System.Windows.Forms.Label();
            this.lblSumTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCountUp = new System.Windows.Forms.Button();
            this.btnCountDown = new System.Windows.Forms.Button();
            this.btnAddPB = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(14, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(849, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "상 품 명";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "단가";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "수량";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "금액";
            this.Column6.Name = "Column6";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "할인";
            this.Column2.Name = "Column2";
            // 
            // btnCode
            // 
            this.btnCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCode.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCode.Location = new System.Drawing.Point(869, 52);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(171, 80);
            this.btnCode.TabIndex = 1;
            this.btnCode.Text = "바코드 입력";
            this.btnCode.UseVisualStyleBackColor = false;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(869, 138);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(171, 80);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "품목 제거";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(869, 224);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 80);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnPayChoice
            // 
            this.btnPayChoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPayChoice.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPayChoice.Location = new System.Drawing.Point(869, 310);
            this.btnPayChoice.Name = "btnPayChoice";
            this.btnPayChoice.Size = new System.Drawing.Size(171, 80);
            this.btnPayChoice.TabIndex = 4;
            this.btnPayChoice.Text = "결제 선택";
            this.btnPayChoice.UseVisualStyleBackColor = false;
            this.btnPayChoice.Click += new System.EventHandler(this.btnPayChoice_Click);
            // 
            // btnDC
            // 
            this.btnDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDC.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDC.Location = new System.Drawing.Point(869, 396);
            this.btnDC.Name = "btnDC";
            this.btnDC.Size = new System.Drawing.Size(171, 80);
            this.btnDC.TabIndex = 5;
            this.btnDC.Text = "결제 후\r\n할인/적립/현금";
            this.btnDC.UseVisualStyleBackColor = false;
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.Yellow;
            this.btnRefund.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefund.Location = new System.Drawing.Point(869, 482);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(171, 80);
            this.btnRefund.TabIndex = 6;
            this.btnRefund.Text = "환 불";
            this.btnRefund.UseVisualStyleBackColor = false;
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.BackColor = System.Drawing.Color.Transparent;
            this.lblVer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblVer.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblVer.Location = new System.Drawing.Point(3, 0);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(62, 46);
            this.lblVer.TabIndex = 9;
            this.lblVer.Text = "Ver.1";
            this.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(17, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 272);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "결제";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(544, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 241);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 60);
            this.label1.TabIndex = 11;
            this.label1.Text = "상품등록";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl4.Location = new System.Drawing.Point(151, 180);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(143, 61);
            this.lbl4.TabIndex = 18;
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 60);
            this.label2.TabIndex = 12;
            this.label2.Text = "받을금액";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Location = new System.Drawing.Point(151, 120);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(143, 60);
            this.lbl3.TabIndex = 17;
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 60);
            this.label3.TabIndex = 13;
            this.label3.Text = "받은금액";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl2.Location = new System.Drawing.Point(151, 60);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(143, 60);
            this.lbl2.TabIndex = 16;
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 61);
            this.label4.TabIndex = 14;
            this.label4.Text = "거스름돈";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1.Location = new System.Drawing.Point(151, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(143, 60);
            this.lbl1.TabIndex = 15;
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(530, 241);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.61765F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.38235F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel2.Controls.Add(this.lblSumdis, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSummoney, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSumcount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSumTotal, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 204);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(750, 39);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // lblSumdis
            // 
            this.lblSumdis.AutoSize = true;
            this.lblSumdis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumdis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSumdis.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSumdis.Location = new System.Drawing.Point(646, 0);
            this.lblSumdis.Name = "lblSumdis";
            this.lblSumdis.Size = new System.Drawing.Size(101, 39);
            this.lblSumdis.TabIndex = 15;
            this.lblSumdis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummoney
            // 
            this.lblSummoney.AutoSize = true;
            this.lblSummoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSummoney.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSummoney.Location = new System.Drawing.Point(540, 0);
            this.lblSummoney.Name = "lblSummoney";
            this.lblSummoney.Size = new System.Drawing.Size(100, 39);
            this.lblSummoney.TabIndex = 14;
            this.lblSummoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumcount
            // 
            this.lblSumcount.AutoSize = true;
            this.lblSumcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSumcount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSumcount.Location = new System.Drawing.Point(442, 0);
            this.lblSumcount.Name = "lblSumcount";
            this.lblSumcount.Size = new System.Drawing.Size(92, 39);
            this.lblSumcount.TabIndex = 13;
            this.lblSumcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSumTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSumTotal.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSumTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSumTotal.Location = new System.Drawing.Point(3, 0);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Size = new System.Drawing.Size(433, 39);
            this.lblSumTotal.TabIndex = 12;
            this.lblSumTotal.Text = "합계 수 량/금 액/할 인";
            this.lblSumTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 616F));
            this.tableLayoutPanel3.Controls.Add(this.lblVer, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDate, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblName, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblUser, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1045, 46);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDate.Location = new System.Drawing.Point(82, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(272, 46);
            this.lblDate.TabIndex = 10;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Location = new System.Drawing.Point(360, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 46);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "사용자 : ";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUser.Location = new System.Drawing.Point(432, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 46);
            this.lblUser.TabIndex = 12;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCountUp
            // 
            this.btnCountUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCountUp.Location = new System.Drawing.Point(17, 246);
            this.btnCountUp.Name = "btnCountUp";
            this.btnCountUp.Size = new System.Drawing.Size(100, 40);
            this.btnCountUp.TabIndex = 20;
            this.btnCountUp.Text = "수량(+)";
            this.btnCountUp.UseVisualStyleBackColor = false;
            // 
            // btnCountDown
            // 
            this.btnCountDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCountDown.Location = new System.Drawing.Point(134, 246);
            this.btnCountDown.Name = "btnCountDown";
            this.btnCountDown.Size = new System.Drawing.Size(100, 40);
            this.btnCountDown.TabIndex = 21;
            this.btnCountDown.Text = "수량(-)";
            this.btnCountDown.UseVisualStyleBackColor = false;
            // 
            // btnAddPB
            // 
            this.btnAddPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAddPB.Location = new System.Drawing.Point(256, 246);
            this.btnAddPB.Name = "btnAddPB";
            this.btnAddPB.Size = new System.Drawing.Size(125, 40);
            this.btnAddPB.TabIndex = 22;
            this.btnAddPB.Text = "쓰레기 봉투(20원)";
            this.btnAddPB.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(17, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 80);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "되돌아가기";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPay.Location = new System.Drawing.Point(712, 570);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(146, 80);
            this.btnPay.TabIndex = 24;
            this.btnPay.Text = "결제 하기";
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 654);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPB);
            this.Controls.Add(this.btnCountDown);
            this.Controls.Add(this.btnCountUp);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnDC);
            this.Controls.Add(this.btnPayChoice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPayChoice;
        private System.Windows.Forms.Button btnDC;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSumdis;
        private System.Windows.Forms.Label lblSummoney;
        private System.Windows.Forms.Label lblSumcount;
        private System.Windows.Forms.Label lblSumTotal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCountUp;
        private System.Windows.Forms.Button btnCountDown;
        private System.Windows.Forms.Button btnAddPB;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPay;
    }
}