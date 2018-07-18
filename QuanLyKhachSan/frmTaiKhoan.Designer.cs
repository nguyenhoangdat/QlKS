namespace QuanLyKhachSan
{
    partial class frmTaiKhoan
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
            this.btnThayDoiMatKhau = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbChucVu = new System.Windows.Forms.TextBox();
            this.txbMANV = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnThayDoiMatKhau
            // 
            this.btnThayDoiMatKhau.Location = new System.Drawing.Point(124, 207);
            this.btnThayDoiMatKhau.Name = "btnThayDoiMatKhau";
            this.btnThayDoiMatKhau.Size = new System.Drawing.Size(80, 40);
            this.btnThayDoiMatKhau.TabIndex = 26;
            this.btnThayDoiMatKhau.Text = "Thay đổi mật khẩu";
            this.btnThayDoiMatKhau.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(210, 207);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 27;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(296, 207);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(80, 40);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkNgaySinh.Location = new System.Drawing.Point(124, 95);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(252, 21);
            this.dtpkNgaySinh.TabIndex = 22;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(177, 69);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 21;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(124, 69);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(46, 17);
            this.rdNam.TabIndex = 20;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(11, 184);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(51, 13);
            this.lblChucVu.TabIndex = 19;
            this.lblChucVu.Text = "Chức vụ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(11, 158);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(73, 13);
            this.lblSDT.TabIndex = 17;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(11, 129);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(43, 13);
            this.lblDiaChi.TabIndex = 12;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(11, 101);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(58, 13);
            this.lblNgaySinh.TabIndex = 16;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(11, 73);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(49, 13);
            this.lblGioiTinh.TabIndex = 15;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(11, 19);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(75, 13);
            this.lblMaNV.TabIndex = 14;
            this.lblMaNV.Text = "Mã nhân viên:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(11, 45);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(43, 13);
            this.lblHoTen.TabIndex = 13;
            this.lblHoTen.Text = "Họ tên:";
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(124, 155);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(252, 21);
            this.txbSDT.TabIndex = 24;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(124, 126);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(252, 21);
            this.txbDiaChi.TabIndex = 23;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Location = new System.Drawing.Point(124, 181);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.ReadOnly = true;
            this.txbChucVu.Size = new System.Drawing.Size(252, 21);
            this.txbChucVu.TabIndex = 25;
            // 
            // txbMANV
            // 
            this.txbMANV.Location = new System.Drawing.Point(124, 13);
            this.txbMANV.Name = "txbMANV";
            this.txbMANV.ReadOnly = true;
            this.txbMANV.Size = new System.Drawing.Size(252, 21);
            this.txbMANV.TabIndex = 11;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(124, 39);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(252, 21);
            this.txbHoTen.TabIndex = 18;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 272);
            this.Controls.Add(this.btnThayDoiMatKhau);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dtpkNgaySinh);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbChucVu);
            this.Controls.Add(this.txbMANV);
            this.Controls.Add(this.txbHoTen);
            this.Name = "frmTaiKhoan";
            this.Text = "Thông Tin Tài Khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThayDoiMatKhau;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbChucVu;
        private System.Windows.Forms.TextBox txbMANV;
        private System.Windows.Forms.TextBox txbHoTen;
    }
}