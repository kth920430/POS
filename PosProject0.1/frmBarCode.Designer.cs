namespace PosProject0._1
{
    partial class frmBarCode
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
            this.txtbarCode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbarCode
            // 
            this.txtbarCode.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtbarCode.Location = new System.Drawing.Point(12, 12);
            this.txtbarCode.Name = "txtbarCode";
            this.txtbarCode.Size = new System.Drawing.Size(334, 26);
            this.txtbarCode.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 26);
            this.button2.TabIndex = 2;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmBarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 48);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbarCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBarCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBarCode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBarCode_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        protected System.Windows.Forms.TextBox txtbarCode;
    }
}