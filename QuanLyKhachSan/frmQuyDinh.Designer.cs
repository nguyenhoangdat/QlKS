namespace QuanLyKhachSan
{
    partial class frmQuyDinh
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
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtTLNC = new System.Windows.Forms.TextBox();
            this.txtTLNT3 = new System.Windows.Forms.TextBox();
            this.lblTLNC = new System.Windows.Forms.Label();
            this.lblTLNT3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(280, 109);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtTLNC
            // 
            this.txtTLNC.Location = new System.Drawing.Point(174, 70);
            this.txtTLNC.Name = "txtTLNC";
            this.txtTLNC.Size = new System.Drawing.Size(186, 21);
            this.txtTLNC.TabIndex = 6;
            // 
            // txtTLNT3
            // 
            this.txtTLNT3.Location = new System.Drawing.Point(174, 29);
            this.txtTLNT3.Name = "txtTLNT3";
            this.txtTLNT3.Size = new System.Drawing.Size(186, 21);
            this.txtTLNT3.TabIndex = 5;
            // 
            // lblTLNC
            // 
            this.lblTLNC.AutoSize = true;
            this.lblTLNC.Location = new System.Drawing.Point(17, 73);
            this.lblTLNC.Name = "lblTLNC";
            this.lblTLNC.Size = new System.Drawing.Size(147, 13);
            this.lblTLNC.TabIndex = 9;
            this.lblTLNC.Text = "Tỉ lệ khi có khách nước ngoài:";
            // 
            // lblTLNT3
            // 
            this.lblTLNT3.AutoSize = true;
            this.lblTLNT3.Location = new System.Drawing.Point(17, 32);
            this.lblTLNT3.Name = "lblTLNT3";
            this.lblTLNT3.Size = new System.Drawing.Size(157, 13);
            this.lblTLNT3.TabIndex = 10;
            this.lblTLNT3.Text = "Tỉ lệ phụ thu người thứ ba (%):";
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 195);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtTLNC);
            this.Controls.Add(this.txtTLNT3);
            this.Controls.Add(this.lblTLNC);
            this.Controls.Add(this.lblTLNT3);
            this.Name = "frmQuyDinh";
            this.Text = "Quy Định";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtTLNC;
        private System.Windows.Forms.TextBox txtTLNT3;
        private System.Windows.Forms.Label lblTLNC;
        private System.Windows.Forms.Label lblTLNT3;
    }
}