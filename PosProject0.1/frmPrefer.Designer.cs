﻿namespace PosProject0._1
{
    partial class frmPrefer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxSName = new System.Windows.Forms.TextBox();
            this.tboxSAddr = new System.Windows.Forms.TextBox();
            this.tboxBNum = new System.Windows.Forms.TextBox();
            this.tboxSTel = new System.Windows.Forms.TextBox();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "매장명";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "주소";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "사업자 번호";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "전화번호";
            // 
            // tboxSName
            // 
            this.tboxSName.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxSName.Location = new System.Drawing.Point(125, 49);
            this.tboxSName.Multiline = true;
            this.tboxSName.Name = "tboxSName";
            this.tboxSName.Size = new System.Drawing.Size(240, 51);
            this.tboxSName.TabIndex = 6;
            // 
            // tboxSAddr
            // 
            this.tboxSAddr.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxSAddr.Location = new System.Drawing.Point(18, 153);
            this.tboxSAddr.Multiline = true;
            this.tboxSAddr.Name = "tboxSAddr";
            this.tboxSAddr.Size = new System.Drawing.Size(520, 53);
            this.tboxSAddr.TabIndex = 8;
            // 
            // tboxBNum
            // 
            this.tboxBNum.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxBNum.Location = new System.Drawing.Point(220, 215);
            this.tboxBNum.Multiline = true;
            this.tboxBNum.Name = "tboxBNum";
            this.tboxBNum.Size = new System.Drawing.Size(318, 57);
            this.tboxBNum.TabIndex = 9;
            // 
            // tboxSTel
            // 
            this.tboxSTel.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxSTel.Location = new System.Drawing.Point(220, 278);
            this.tboxSTel.Multiline = true;
            this.tboxSTel.Name = "tboxSTel";
            this.tboxSTel.Size = new System.Drawing.Size(318, 54);
            this.tboxSTel.TabIndex = 10;
            // 
            // btnModi
            // 
            this.btnModi.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModi.Location = new System.Drawing.Point(39, 355);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(148, 109);
            this.btnModi.TabIndex = 12;
            this.btnModi.Text = "수정";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancle.Location = new System.Drawing.Point(390, 355);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(148, 109);
            this.btnCancle.TabIndex = 13;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // frmPrefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 476);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.tboxSTel);
            this.Controls.Add(this.tboxBNum);
            this.Controls.Add(this.tboxSAddr);
            this.Controls.Add(this.tboxSName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrefer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "환경설정";
            this.Load += new System.EventHandler(this.frmPrefer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxSName;
        private System.Windows.Forms.TextBox tboxSAddr;
        private System.Windows.Forms.TextBox tboxBNum;
        private System.Windows.Forms.TextBox tboxSTel;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnCancle;
    }
}