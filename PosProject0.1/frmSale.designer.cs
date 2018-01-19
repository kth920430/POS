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
            this.btnCode = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefundCard = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblget = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblneed = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDC = new System.Windows.Forms.Label();
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnRefundCash = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(841, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
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
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefundCard
            // 
            this.btnRefundCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRefundCard.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefundCard.Location = new System.Drawing.Point(869, 484);
            this.btnRefundCard.Name = "btnRefundCard";
            this.btnRefundCard.Size = new System.Drawing.Size(171, 80);
            this.btnRefundCard.TabIndex = 6;
            this.btnRefundCard.Text = "환 불 (카드)";
            this.btnRefundCard.UseVisualStyleBackColor = false;
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
            this.tableLayoutPanel1.Controls.Add(this.lblChange, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblget, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblneed, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDC, 1, 0);
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
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 60);
            this.label1.TabIndex = 11;
            this.label1.Text = "할 인";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChange.Location = new System.Drawing.Point(151, 180);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(143, 61);
            this.lblChange.TabIndex = 18;
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(3, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 60);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "합계금액?";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblget
            // 
            this.lblget.AutoSize = true;
            this.lblget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblget.Location = new System.Drawing.Point(151, 120);
            this.lblget.Name = "lblget";
            this.lblget.Size = new System.Drawing.Size(143, 60);
            this.lblget.TabIndex = 17;
            this.lblget.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 60);
            this.label3.TabIndex = 13;
            this.label3.Text = "받은금액";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblneed
            // 
            this.lblneed.AutoSize = true;
            this.lblneed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblneed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblneed.Location = new System.Drawing.Point(151, 60);
            this.lblneed.Name = "lblneed";
            this.lblneed.Size = new System.Drawing.Size(143, 60);
            this.lblneed.TabIndex = 16;
            this.lblneed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 61);
            this.label4.TabIndex = 14;
            this.label4.Text = "거스름돈";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDC
            // 
            this.lblDC.AutoSize = true;
            this.lblDC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblDC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDC.Location = new System.Drawing.Point(151, 0);
            this.lblDC.Name = "lblDC";
            this.lblDC.Size = new System.Drawing.Size(143, 60);
            this.lblDC.TabIndex = 15;
            this.lblDC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel2.Controls.Add(this.lblSumdis, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSummoney, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSumcount, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSumTotal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPrice, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 204);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(841, 39);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // lblSumdis
            // 
            this.lblSumdis.AutoSize = true;
            this.lblSumdis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumdis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSumdis.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSumdis.Location = new System.Drawing.Point(619, 0);
            this.lblSumdis.Name = "lblSumdis";
            this.lblSumdis.Size = new System.Drawing.Size(103, 39);
            this.lblSumdis.TabIndex = 15;
            this.lblSumdis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSummoney
            // 
            this.lblSummoney.AutoSize = true;
            this.lblSummoney.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSummoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSummoney.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSummoney.Location = new System.Drawing.Point(528, 0);
            this.lblSummoney.Name = "lblSummoney";
            this.lblSummoney.Size = new System.Drawing.Size(85, 39);
            this.lblSummoney.TabIndex = 14;
            this.lblSummoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSumcount
            // 
            this.lblSumcount.AutoSize = true;
            this.lblSumcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSumcount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSumcount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblSumcount.Location = new System.Drawing.Point(447, 0);
            this.lblSumcount.Name = "lblSumcount";
            this.lblSumcount.Size = new System.Drawing.Size(75, 39);
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
            this.lblSumTotal.Size = new System.Drawing.Size(438, 39);
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
            this.btnCountUp.Click += new System.EventHandler(this.btnCountUp_Click);
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
            this.btnCountDown.Click += new System.EventHandler(this.btnCountDown_Click);
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
            this.btnAddPB.Click += new System.EventHandler(this.btnAddPB_Click);
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
            this.btnPay.Location = new System.Drawing.Point(717, 570);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(146, 80);
            this.btnPay.TabIndex = 24;
            this.btnPay.Text = "결제 하기";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 80);
            this.button1.TabIndex = 20;
            this.button1.Text = "키보드";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCard
            // 
            this.btnCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCard.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCard.Location = new System.Drawing.Point(869, 310);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(171, 80);
            this.btnCard.TabIndex = 25;
            this.btnCard.Text = "카드 결제";
            this.btnCard.UseVisualStyleBackColor = false;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // txtBarcode
            // 
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBarcode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtBarcode.Location = new System.Drawing.Point(385, 260);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(468, 19);
            this.txtBarcode.TabIndex = 27;
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCash.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCash.Location = new System.Drawing.Point(869, 396);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(171, 80);
            this.btnCash.TabIndex = 26;
            this.btnCash.Text = "현금 결제";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnRefundCash
            // 
            this.btnRefundCash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRefundCash.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefundCash.Location = new System.Drawing.Point(561, 570);
            this.btnRefundCash.Name = "btnRefundCash";
            this.btnRefundCash.Size = new System.Drawing.Size(146, 80);
            this.btnRefundCash.TabIndex = 28;
            this.btnRefundCash.Text = "환 불 (현금)";
            this.btnRefundCash.UseVisualStyleBackColor = false;
            this.btnRefundCash.Click += new System.EventHandler(this.btnRefundCash_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(728, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(110, 39);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 654);
            this.Controls.Add(this.btnRefundCash);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddPB);
            this.Controls.Add(this.btnCountDown);
            this.Controls.Add(this.btnCountUp);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefundCard);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefundCard;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
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
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblSumdis;
        public System.Windows.Forms.Label lblSummoney;
        public System.Windows.Forms.Label lblSumcount;
        public System.Windows.Forms.Label lblneed;
        private System.Windows.Forms.Button btnCard;
        public System.Windows.Forms.Label lblget;
        public System.Windows.Forms.Label lblChange;
        public System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnRefundCash;
        public System.Windows.Forms.Label lblDC;
        public System.Windows.Forms.Label lblPrice;
    }
}