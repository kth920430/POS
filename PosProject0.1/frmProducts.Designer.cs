namespace PosProject0._1
{
    partial class frmProducts
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnProDel = new System.Windows.Forms.Button();
            this.btnProModi = new System.Windows.Forms.Button();
            this.btnProAdd = new System.Windows.Forms.Button();
            this.cboxSup = new System.Windows.Forms.ComboBox();
            this.cboxEve = new System.Windows.Forms.ComboBox();
            this.cboxCat = new System.Windows.Forms.ComboBox();
            this.tboxPurchase = new System.Windows.Forms.TextBox();
            this.tboxProprice = new System.Windows.Forms.TextBox();
            this.tboxProName = new System.Windows.Forms.TextBox();
            this.tboxBarcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxProSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxBarcodeSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(3, 429);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(194, 153);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "새로고침";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancle.Location = new System.Drawing.Point(3, 588);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(187, 138);
            this.btnCancle.TabIndex = 20;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnProDel
            // 
            this.btnProDel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProDel.Location = new System.Drawing.Point(3, 151);
            this.btnProDel.Name = "btnProDel";
            this.btnProDel.Size = new System.Drawing.Size(194, 123);
            this.btnProDel.TabIndex = 19;
            this.btnProDel.Text = "삭제";
            this.btnProDel.UseVisualStyleBackColor = true;
            this.btnProDel.Click += new System.EventHandler(this.btnProDel_Click);
            // 
            // btnProModi
            // 
            this.btnProModi.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProModi.Location = new System.Drawing.Point(3, 280);
            this.btnProModi.Name = "btnProModi";
            this.btnProModi.Size = new System.Drawing.Size(194, 143);
            this.btnProModi.TabIndex = 18;
            this.btnProModi.Text = "수정";
            this.btnProModi.UseVisualStyleBackColor = true;
            this.btnProModi.Click += new System.EventHandler(this.btnProModi_Click);
            // 
            // btnProAdd
            // 
            this.btnProAdd.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProAdd.Location = new System.Drawing.Point(3, 3);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(194, 142);
            this.btnProAdd.TabIndex = 17;
            this.btnProAdd.Text = "저장";
            this.btnProAdd.UseVisualStyleBackColor = true;
            this.btnProAdd.Click += new System.EventHandler(this.btnProAdd_Click);
            // 
            // cboxSup
            // 
            this.cboxSup.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxSup.FormattingEnabled = true;
            this.cboxSup.Location = new System.Drawing.Point(223, 328);
            this.cboxSup.Name = "cboxSup";
            this.cboxSup.Size = new System.Drawing.Size(272, 35);
            this.cboxSup.TabIndex = 16;
            // 
            // cboxEve
            // 
            this.cboxEve.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxEve.FormattingEnabled = true;
            this.cboxEve.Location = new System.Drawing.Point(226, 386);
            this.cboxEve.Name = "cboxEve";
            this.cboxEve.Size = new System.Drawing.Size(272, 35);
            this.cboxEve.TabIndex = 15;
            // 
            // cboxCat
            // 
            this.cboxCat.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxCat.FormattingEnabled = true;
            this.cboxCat.Location = new System.Drawing.Point(223, 268);
            this.cboxCat.Name = "cboxCat";
            this.cboxCat.Size = new System.Drawing.Size(272, 35);
            this.cboxCat.TabIndex = 14;
            // 
            // tboxPurchase
            // 
            this.tboxPurchase.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxPurchase.Location = new System.Drawing.Point(192, 208);
            this.tboxPurchase.Multiline = true;
            this.tboxPurchase.Name = "tboxPurchase";
            this.tboxPurchase.Size = new System.Drawing.Size(303, 37);
            this.tboxPurchase.TabIndex = 13;
            // 
            // tboxProprice
            // 
            this.tboxProprice.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxProprice.Location = new System.Drawing.Point(144, 148);
            this.tboxProprice.Multiline = true;
            this.tboxProprice.Name = "tboxProprice";
            this.tboxProprice.Size = new System.Drawing.Size(354, 37);
            this.tboxProprice.TabIndex = 12;
            // 
            // tboxProName
            // 
            this.tboxProName.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxProName.Location = new System.Drawing.Point(144, 90);
            this.tboxProName.Multiline = true;
            this.tboxProName.Name = "tboxProName";
            this.tboxProName.Size = new System.Drawing.Size(354, 37);
            this.tboxProName.TabIndex = 11;
            // 
            // tboxBarcode
            // 
            this.tboxBarcode.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxBarcode.Location = new System.Drawing.Point(144, 35);
            this.tboxBarcode.Multiline = true;
            this.tboxBarcode.Name = "tboxBarcode";
            this.tboxBarcode.Size = new System.Drawing.Size(354, 37);
            this.tboxBarcode.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(10, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 37);
            this.label8.TabIndex = 8;
            this.label8.Text = "공급업체";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 37);
            this.label7.TabIndex = 7;
            this.label7.Text = "구매 비용";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "상품명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 37);
            this.label4.TabIndex = 4;
            this.label4.Text = "바코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 37);
            this.label3.TabIndex = 3;
            this.label3.Text = "이벤트 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(10, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "종류";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboxSup);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cboxEve);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cboxCat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tboxPurchase);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tboxBarcode);
            this.panel1.Controls.Add(this.tboxProprice);
            this.panel1.Controls.Add(this.tboxProName);
            this.panel1.Location = new System.Drawing.Point(1035, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 547);
            this.panel1.TabIndex = 49;
            // 
            // tboxProSearch
            // 
            this.tboxProSearch.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxProSearch.Location = new System.Drawing.Point(116, 3);
            this.tboxProSearch.Multiline = true;
            this.tboxProSearch.Name = "tboxProSearch";
            this.tboxProSearch.Size = new System.Drawing.Size(319, 37);
            this.tboxProSearch.TabIndex = 51;
            this.tboxProSearch.TextChanged += new System.EventHandler(this.tboxProSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "검색어:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1739, 37);
            this.toolStrip1.TabIndex = 53;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.Info;
            this.toolStripLabel1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(143, 34);
            this.toolStripLabel1.Text = "상품관리";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 34);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.79909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.20091F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 305F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.btnEnd, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxCategory, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcel, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxProSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxBarcodeSearch, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.276438F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1739, 45);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEnd.Location = new System.Drawing.Point(1620, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(115, 39);
            this.btnEnd.TabIndex = 56;
            this.btnEnd.Text = "종료";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // cboxCategory
            // 
            this.cboxCategory.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(1034, 3);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(299, 35);
            this.cboxCategory.TabIndex = 56;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.Location = new System.Drawing.Point(1466, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(148, 39);
            this.btnExcel.TabIndex = 55;
            this.btnExcel.Text = "액셀저장";
            this.btnExcel.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(441, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(122, 37);
            this.panel4.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(16, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 28);
            this.label10.TabIndex = 56;
            this.label10.Text = "바코드:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 37);
            this.panel2.TabIndex = 55;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(903, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 39);
            this.panel3.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(10, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 55;
            this.label9.Text = "상품별:";
            // 
            // tboxBarcodeSearch
            // 
            this.tboxBarcodeSearch.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxBarcodeSearch.Location = new System.Drawing.Point(569, 3);
            this.tboxBarcodeSearch.Multiline = true;
            this.tboxBarcodeSearch.Name = "tboxBarcodeSearch";
            this.tboxBarcodeSearch.Size = new System.Drawing.Size(327, 37);
            this.tboxBarcodeSearch.TabIndex = 59;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnCancle, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnProDel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnProModi, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnProAdd, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1539, 94);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.36134F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.63866F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 729);
            this.tableLayoutPanel3.TabIndex = 56;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 717);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1739, 925);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxSup;
        private System.Windows.Forms.ComboBox cboxEve;
        private System.Windows.Forms.ComboBox cboxCat;
        private System.Windows.Forms.TextBox tboxPurchase;
        private System.Windows.Forms.TextBox tboxProprice;
        private System.Windows.Forms.TextBox tboxProName;
        private System.Windows.Forms.TextBox tboxBarcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnProDel;
        private System.Windows.Forms.Button btnProModi;
        private System.Windows.Forms.Button btnProAdd;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxProSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.TextBox tboxBarcodeSearch;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}