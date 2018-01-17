namespace PosProject0._1
{
    partial class frmSalesManager
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
            this.btnSalesPayment = new System.Windows.Forms.Button();
            this.btnSalesProducts = new System.Windows.Forms.Button();
            this.btnSalesDate = new System.Windows.Forms.Button();
            this.btnSalesStatus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalesPayment
            // 
            this.btnSalesPayment.BackgroundImage = global::PosProject0._1.Properties.Resources.payment;
            this.btnSalesPayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalesPayment.FlatAppearance.BorderSize = 0;
            this.btnSalesPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesPayment.Location = new System.Drawing.Point(456, 284);
            this.btnSalesPayment.Name = "btnSalesPayment";
            this.btnSalesPayment.Size = new System.Drawing.Size(167, 163);
            this.btnSalesPayment.TabIndex = 3;
            this.btnSalesPayment.UseVisualStyleBackColor = true;
            // 
            // btnSalesProducts
            // 
            this.btnSalesProducts.BackgroundImage = global::PosProject0._1.Properties.Resources.products;
            this.btnSalesProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalesProducts.FlatAppearance.BorderSize = 0;
            this.btnSalesProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesProducts.Location = new System.Drawing.Point(201, 284);
            this.btnSalesProducts.Name = "btnSalesProducts";
            this.btnSalesProducts.Size = new System.Drawing.Size(167, 163);
            this.btnSalesProducts.TabIndex = 2;
            this.btnSalesProducts.UseVisualStyleBackColor = true;
            // 
            // btnSalesDate
            // 
            this.btnSalesDate.BackgroundImage = global::PosProject0._1.Properties.Resources.date;
            this.btnSalesDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalesDate.FlatAppearance.BorderSize = 0;
            this.btnSalesDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesDate.Location = new System.Drawing.Point(456, 87);
            this.btnSalesDate.Name = "btnSalesDate";
            this.btnSalesDate.Size = new System.Drawing.Size(167, 163);
            this.btnSalesDate.TabIndex = 1;
            this.btnSalesDate.UseVisualStyleBackColor = true;
            // 
            // btnSalesStatus
            // 
            this.btnSalesStatus.BackgroundImage = global::PosProject0._1.Properties.Resources.sales;
            this.btnSalesStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalesStatus.FlatAppearance.BorderSize = 0;
            this.btnSalesStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesStatus.Location = new System.Drawing.Point(201, 87);
            this.btnSalesStatus.Name = "btnSalesStatus";
            this.btnSalesStatus.Size = new System.Drawing.Size(167, 163);
            this.btnSalesStatus.TabIndex = 0;
            this.btnSalesStatus.UseVisualStyleBackColor = true;
            this.btnSalesStatus.Click += new System.EventHandler(this.btnSalesStatus_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanel1.Controls.Add(this.btnSalesDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalesProducts, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSalesPayment, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSalesStatus, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(826, 565);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // frmSalesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSalesManager";
            this.Text = "frmSalesManager";
            this.Load += new System.EventHandler(this.frmSalesManager_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalesStatus;
        private System.Windows.Forms.Button btnSalesDate;
        private System.Windows.Forms.Button btnSalesProducts;
        private System.Windows.Forms.Button btnSalesPayment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}