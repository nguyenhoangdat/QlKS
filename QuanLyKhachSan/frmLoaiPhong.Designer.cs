namespace QuanLyKhachSan
{
    partial class frmLoaiPhong
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.txbTim = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.lblMaLP = new System.Windows.Forms.Label();
            this.dgvThietBi = new System.Windows.Forms.DataGridView();
            this.gcLoaiPhong = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnThemTB = new DevExpress.XtraEditors.SimpleButton();
            this.pnlFrmThemThietBi = new System.Windows.Forms.Panel();
            this.btnHide = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaThietBi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên loại:";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(325, 31);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(57, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txbTim
            // 
            this.txbTim.AllowDrop = true;
            this.txbTim.Location = new System.Drawing.Point(151, 31);
            this.txbTim.Name = "txbTim";
            this.txbTim.Size = new System.Drawing.Size(168, 21);
            this.txbTim.TabIndex = 4;
            this.txbTim.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbTim_KeyDown);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(559, 79);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(173, 21);
            this.txtGia.TabIndex = 51;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(559, 49);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(173, 21);
            this.txtTen.TabIndex = 50;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(559, 19);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.Size = new System.Drawing.Size(173, 21);
            this.txtMaLoai.TabIndex = 49;
            this.txtMaLoai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaLoai_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thiết bị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Mã loại phòng:";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(648, 106);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 43);
            this.btnXoa.TabIndex = 52;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(541, 106);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 43);
            this.btnCapNhat.TabIndex = 53;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(434, 106);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(101, 43);
            this.btnThemMoi.TabIndex = 54;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // lblMaLP
            // 
            this.lblMaLP.Location = new System.Drawing.Point(556, 157);
            this.lblMaLP.Name = "lblMaLP";
            this.lblMaLP.Size = new System.Drawing.Size(0, 23);
            this.lblMaLP.TabIndex = 56;
            this.lblMaLP.Text = "label6";
            this.lblMaLP.TextChanged += new System.EventHandler(this.lblMaLP_TextChanged);
            // 
            // dgvThietBi
            // 
            this.dgvThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietBi.Location = new System.Drawing.Point(437, 237);
            this.dgvThietBi.Name = "dgvThietBi";
            this.dgvThietBi.Size = new System.Drawing.Size(250, 196);
            this.dgvThietBi.TabIndex = 55;
            // 
            // gcLoaiPhong
            // 
            this.gcLoaiPhong.Location = new System.Drawing.Point(11, 60);
            this.gcLoaiPhong.MainView = this.gvLoaiPhong;
            this.gcLoaiPhong.Name = "gcLoaiPhong";
            this.gcLoaiPhong.Size = new System.Drawing.Size(390, 373);
            this.gcLoaiPhong.TabIndex = 57;
            this.gcLoaiPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiPhong});
            // 
            // gvLoaiPhong
            // 
            this.gvLoaiPhong.GridControl = this.gcLoaiPhong;
            this.gvLoaiPhong.Name = "gvLoaiPhong";
            // 
            // btnThemTB
            // 
            this.btnThemTB.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTB.Appearance.Options.UseFont = true;
            this.btnThemTB.Location = new System.Drawing.Point(693, 390);
            this.btnThemTB.Name = "btnThemTB";
            this.btnThemTB.Size = new System.Drawing.Size(101, 43);
            this.btnThemTB.TabIndex = 54;
            this.btnThemTB.Text = "Thêm TB >>";
            this.btnThemTB.Click += new System.EventHandler(this.btnThemTB_Click);
            // 
            // pnlFrmThemThietBi
            // 
            this.pnlFrmThemThietBi.Location = new System.Drawing.Point(800, 211);
            this.pnlFrmThemThietBi.Name = "pnlFrmThemThietBi";
            this.pnlFrmThemThietBi.Size = new System.Drawing.Size(337, 236);
            this.pnlFrmThemThietBi.TabIndex = 58;
            // 
            // btnHide
            // 
            this.btnHide.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHide.Appearance.Options.UseFont = true;
            this.btnHide.Location = new System.Drawing.Point(693, 341);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(101, 43);
            this.btnHide.TabIndex = 54;
            this.btnHide.Text = "<<";
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnXoaThietBi
            // 
            this.btnXoaThietBi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThietBi.Appearance.Options.UseFont = true;
            this.btnXoaThietBi.Location = new System.Drawing.Point(693, 292);
            this.btnXoaThietBi.Name = "btnXoaThietBi";
            this.btnXoaThietBi.Size = new System.Drawing.Size(101, 43);
            this.btnXoaThietBi.TabIndex = 52;
            this.btnXoaThietBi.Text = "Xóa";
            this.btnXoaThietBi.Click += new System.EventHandler(this.btnXoaThietBi_Click);
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 499);
            this.Controls.Add(this.pnlFrmThemThietBi);
            this.Controls.Add(this.gcLoaiPhong);
            this.Controls.Add(this.lblMaLP);
            this.Controls.Add(this.dgvThietBi);
            this.Controls.Add(this.btnXoaThietBi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.btnThemTB);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.txbTim);
            this.Name = "frmLoaiPhong";
            this.Text = "Loại Phòng";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txbTim;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private System.Windows.Forms.Label lblMaLP;
        private System.Windows.Forms.DataGridView dgvThietBi;
        private DevExpress.XtraGrid.GridControl gcLoaiPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiPhong;
        private DevExpress.XtraEditors.SimpleButton btnThemTB;
        private System.Windows.Forms.Panel pnlFrmThemThietBi;
        private DevExpress.XtraEditors.SimpleButton btnHide;
        private DevExpress.XtraEditors.SimpleButton btnXoaThietBi;
    }
}