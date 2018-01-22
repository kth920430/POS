namespace PosProject0._1
{
    partial class frmCategory
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
            this.CategoryView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tboxCatNum = new System.Windows.Forms.TextBox();
            this.tboxCatName = new System.Windows.Forms.TextBox();
            this.btnCatAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoryView
            // 
            this.CategoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoryView.Location = new System.Drawing.Point(12, 12);
            this.CategoryView.Name = "CategoryView";
            this.CategoryView.RowTemplate.Height = 23;
            this.CategoryView.Size = new System.Drawing.Size(243, 342);
            this.CategoryView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "종류 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "종류 이름";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(261, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tboxCatNum);
            this.splitContainer1.Size = new System.Drawing.Size(306, 59);
            this.splitContainer1.SplitterDistance = 102;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(262, 78);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tboxCatName);
            this.splitContainer2.Size = new System.Drawing.Size(305, 53);
            this.splitContainer2.SplitterDistance = 101;
            this.splitContainer2.TabIndex = 4;
            // 
            // tboxCatNum
            // 
            this.tboxCatNum.Location = new System.Drawing.Point(25, 14);
            this.tboxCatNum.Multiline = true;
            this.tboxCatNum.Name = "tboxCatNum";
            this.tboxCatNum.Size = new System.Drawing.Size(100, 21);
            this.tboxCatNum.TabIndex = 5;
            // 
            // tboxCatName
            // 
            this.tboxCatName.Location = new System.Drawing.Point(25, 16);
            this.tboxCatName.Multiline = true;
            this.tboxCatName.Name = "tboxCatName";
            this.tboxCatName.Size = new System.Drawing.Size(100, 21);
            this.tboxCatName.TabIndex = 6;
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Location = new System.Drawing.Point(263, 323);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCatAdd.TabIndex = 5;
            this.btnCatAdd.Text = "추가";
            this.btnCatAdd.UseVisualStyleBackColor = true;
            this.btnCatAdd.Click += new System.EventHandler(this.btnCatAdd_Click_1);
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 358);
            this.Controls.Add(this.btnCatAdd);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.CategoryView);
            this.Name = "frmCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCategory";
            this.Load += new System.EventHandler(this.frmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoryView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoryView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox tboxCatNum;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox tboxCatName;
        private System.Windows.Forms.Button btnCatAdd;
    }
}