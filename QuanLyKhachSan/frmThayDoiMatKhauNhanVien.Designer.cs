namespace QuanLyKhachSan
{
    partial class frmThayDoiMatKhauNhanVien
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txbMayKhauMoiLan2 = new System.Windows.Forms.TextBox();
            this.txbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txbMatKhauCu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(212, 90);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(298, 90);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập lại mật khẩu mới:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mật khẩu mới:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(19, 15);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(69, 13);
            this.lblHoTen.TabIndex = 9;
            this.lblHoTen.Text = "Mật khẩu củ:";
            // 
            // txbMayKhauMoiLan2
            // 
            this.txbMayKhauMoiLan2.Location = new System.Drawing.Point(137, 64);
            this.txbMayKhauMoiLan2.Name = "txbMayKhauMoiLan2";
            this.txbMayKhauMoiLan2.Size = new System.Drawing.Size(241, 21);
            this.txbMayKhauMoiLan2.TabIndex = 10;
            this.txbMayKhauMoiLan2.UseSystemPasswordChar = true;
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(137, 38);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(241, 21);
            this.txbMatKhauMoi.TabIndex = 6;
            this.txbMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(137, 12);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(241, 21);
            this.txbMatKhauCu.TabIndex = 5;
            this.txbMatKhauCu.UseSystemPasswordChar = true;
            // 
            // frmThayDoiMatKhauNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 149);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txbMayKhauMoiLan2);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.txbMatKhauCu);
            this.Name = "frmThayDoiMatKhauNhanVien";
            this.Text = "Cập Nhật Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txbMayKhauMoiLan2;
        private System.Windows.Forms.TextBox txbMatKhauMoi;
        private System.Windows.Forms.TextBox txbMatKhauCu;
    }
}