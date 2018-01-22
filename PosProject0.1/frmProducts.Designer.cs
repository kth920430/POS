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
            this.lblCateAdd = new System.Windows.Forms.Label();
            this.tboxProSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.tboxBarcodeSearch = new System.Windows.Forms.TextBox();
            this.cboxCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImg = new System.Windows.Forms.Button();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.ProductImg = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImg)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.Location = new System.Drawing.Point(3, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(178, 139);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "새로고침";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancle.Location = new System.Drawing.Point(3, 506);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(178, 140);
            this.btnCancle.TabIndex = 20;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnProDel
            // 
            this.btnProDel.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProDel.Location = new System.Drawing.Point(3, 117);
            this.btnProDel.Name = "btnProDel";
            this.btnProDel.Size = new System.Drawing.Size(178, 105);
            this.btnProDel.TabIndex = 19;
            this.btnProDel.Text = "삭제";
            this.btnProDel.UseVisualStyleBackColor = true;
            this.btnProDel.Click += new System.EventHandler(this.btnProDel_Click);
            // 
            // btnProModi
            // 
            this.btnProModi.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProModi.Location = new System.Drawing.Point(3, 228);
            this.btnProModi.Name = "btnProModi";
            this.btnProModi.Size = new System.Drawing.Size(178, 127);
            this.btnProModi.TabIndex = 18;
            this.btnProModi.Text = "수정";
            this.btnProModi.UseVisualStyleBackColor = true;
            this.btnProModi.Click += new System.EventHandler(this.btnProModi_Click);
            // 
            // btnProAdd
            // 
            this.btnProAdd.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnProAdd.Location = new System.Drawing.Point(3, 3);
            this.btnProAdd.Name = "btnProAdd";
            this.btnProAdd.Size = new System.Drawing.Size(178, 108);
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
            this.label8.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(3, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "공급업체";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(3, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 39);
            this.label7.TabIndex = 7;
            this.label7.Text = "구매 비용";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(3, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "가격";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(3, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 39);
            this.label5.TabIndex = 5;
            this.label5.Text = "상품명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 39);
            this.label4.TabIndex = 4;
            this.label4.Text = "바코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(3, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "이벤트 선택";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(3, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "종류";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCateAdd);
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
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 429);
            this.panel1.TabIndex = 49;
            // 
            // lblCateAdd
            // 
            this.lblCateAdd.AutoSize = true;
            this.lblCateAdd.Font = new System.Drawing.Font("휴먼둥근헤드라인", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCateAdd.Location = new System.Drawing.Point(100, 273);
            this.lblCateAdd.Name = "lblCateAdd";
            this.lblCateAdd.Size = new System.Drawing.Size(31, 25);
            this.lblCateAdd.TabIndex = 17;
            this.lblCateAdd.Text = "+";
            this.lblCateAdd.Click += new System.EventHandler(this.lblCateAdd_Click);
            // 
            // tboxProSearch
            // 
            this.tboxProSearch.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxProSearch.Location = new System.Drawing.Point(165, 3);
            this.tboxProSearch.Multiline = true;
            this.tboxProSearch.Name = "tboxProSearch";
            this.tboxProSearch.Size = new System.Drawing.Size(385, 45);
            this.tboxProSearch.TabIndex = 51;
            this.tboxProSearch.TextChanged += new System.EventHandler(this.tboxProSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "검색어:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.38053F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.61947F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 335F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 318F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExcel, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxBarcodeSearch, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.tboxProSearch, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboxCategory, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.276438F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1733, 51);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(556, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 45);
            this.panel4.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(37, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 28);
            this.label10.TabIndex = 56;
            this.label10.Text = "바코드:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(1071, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(176, 45);
            this.panel3.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(30, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 55;
            this.label9.Text = "상품별:";
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExcel.Location = new System.Drawing.Point(1571, 3);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(159, 45);
            this.btnExcel.TabIndex = 55;
            this.btnExcel.Text = "액셀저장";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // tboxBarcodeSearch
            // 
            this.tboxBarcodeSearch.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxBarcodeSearch.Location = new System.Drawing.Point(736, 3);
            this.tboxBarcodeSearch.Multiline = true;
            this.tboxBarcodeSearch.Name = "tboxBarcodeSearch";
            this.tboxBarcodeSearch.Size = new System.Drawing.Size(327, 45);
            this.tboxBarcodeSearch.TabIndex = 59;
            this.tboxBarcodeSearch.TextChanged += new System.EventHandler(this.tboxBarcodeSearch_TextChanged);
            // 
            // cboxCategory
            // 
            this.cboxCategory.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboxCategory.FormattingEnabled = true;
            this.cboxCategory.Location = new System.Drawing.Point(1253, 3);
            this.cboxCategory.Name = "cboxCategory";
            this.cboxCategory.Size = new System.Drawing.Size(312, 45);
            this.cboxCategory.TabIndex = 56;
            this.cboxCategory.TextChanged += new System.EventHandler(this.cboxCategory_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 45);
            this.panel2.TabIndex = 55;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnProDel, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnReset, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btnProModi, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnCancle, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btnImg, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.btnProAdd, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1546, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(184, 799);
            this.tableLayoutPanel3.TabIndex = 56;
            // 
            // btnImg
            // 
            this.btnImg.Font = new System.Drawing.Font("휴먼둥근헤드라인", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnImg.Location = new System.Drawing.Point(3, 652);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(178, 141);
            this.btnImg.TabIndex = 59;
            this.btnImg.Text = "사진추가";
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // ProductView
            // 
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(3, 3);
            this.ProductView.Name = "ProductView";
            this.ProductView.RowTemplate.Height = 23;
            this.ProductView.Size = new System.Drawing.Size(1014, 796);
            this.ProductView.TabIndex = 57;
            this.ProductView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductView_CellClick);
            this.ProductView.Click += new System.EventHandler(this.ProductView_Click);
            // 
            // ProductImg
            // 
            this.ProductImg.Location = new System.Drawing.Point(3, 438);
            this.ProductImg.Name = "ProductImg";
            this.ProductImg.Size = new System.Drawing.Size(511, 355);
            this.ProductImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProductImg.TabIndex = 58;
            this.ProductImg.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1739, 885);
            this.tableLayoutPanel2.TabIndex = 59;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 523F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel4.Controls.Add(this.ProductView, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 61);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.50916F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1733, 805);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ProductImg, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(1023, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.77387F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.22613F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(517, 796);
            this.tableLayoutPanel5.TabIndex = 58;
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
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
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
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1739, 925);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProducts";
            this.Text = "frmProducts";
            this.Load += new System.EventHandler(this.frmProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductImg)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tboxBarcodeSearch;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.PictureBox ProductImg;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblCateAdd;
        internal System.Windows.Forms.ComboBox cboxCat;
        internal System.Windows.Forms.ComboBox cboxCategory;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}