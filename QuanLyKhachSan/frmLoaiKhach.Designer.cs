namespace QuanLyKhachSan
{
    partial class frmLoaiKhach
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
            this.txtTenNuoc = new System.Windows.Forms.TextBox();
            this.txtMaQT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.lblThongtin = new System.Windows.Forms.Label();
            this.gcLoaiKhach = new DevExpress.XtraGrid.GridControl();
            this.gvLoaiKhach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchAccount = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchAccount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenNuoc
            // 
            this.txtTenNuoc.Location = new System.Drawing.Point(132, 116);
            this.txtTenNuoc.Name = "txtTenNuoc";
            this.txtTenNuoc.Size = new System.Drawing.Size(173, 21);
            this.txtTenNuoc.TabIndex = 51;
            // 
            // txtMaQT
            // 
            this.txtMaQT.Location = new System.Drawing.Point(132, 86);
            this.txtMaQT.Name = "txtMaQT";
            this.txtMaQT.Size = new System.Drawing.Size(173, 21);
            this.txtMaQT.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Tên loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã loại:";
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(215, 168);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 43);
            this.btnXoa.TabIndex = 55;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Location = new System.Drawing.Point(108, 168);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 43);
            this.btnCapNhat.TabIndex = 56;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Location = new System.Drawing.Point(3, 168);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(101, 43);
            this.btnThemMoi.TabIndex = 57;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // lblThongtin
            // 
            this.lblThongtin.AutoSize = true;
            this.lblThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongtin.Location = new System.Drawing.Point(81, 21);
            this.lblThongtin.Name = "lblThongtin";
            this.lblThongtin.Size = new System.Drawing.Size(172, 22);
            this.lblThongtin.TabIndex = 58;
            this.lblThongtin.Text = "Thông tin loại khách";
            // 
            // gcLoaiKhach
            // 
            this.gcLoaiKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcLoaiKhach.Location = new System.Drawing.Point(2, 217);
            this.gcLoaiKhach.MainView = this.gvLoaiKhach;
            this.gcLoaiKhach.Name = "gcLoaiKhach";
            this.gcLoaiKhach.Size = new System.Drawing.Size(768, 248);
            this.gcLoaiKhach.TabIndex = 87;
            this.gcLoaiKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLoaiKhach});
            // 
            // gvLoaiKhach
            // 
            this.gvLoaiKhach.GridControl = this.gcLoaiKhach;
            this.gvLoaiKhach.Name = "gvLoaiKhach";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(535, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 35);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchAccount.EditValue = "";
            this.txtSearchAccount.Location = new System.Drawing.Point(349, 182);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Properties.Appearance.Options.UseFont = true;
            this.txtSearchAccount.Properties.NullText = "-- Tìm tên nhân viên --";
            this.txtSearchAccount.Properties.NullValuePrompt = "-- Tìm tên nhân viên --";
            this.txtSearchAccount.Size = new System.Drawing.Size(180, 24);
            this.txtSearchAccount.TabIndex = 90;
            this.txtSearchAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchAccount_KeyDown);
            // 
            // frmLoaiKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 468);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.gcLoaiKhach);
            this.Controls.Add(this.lblThongtin);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.txtTenNuoc);
            this.Controls.Add(this.txtMaQT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmLoaiKhach";
            this.Text = "Loại Khách";
            this.Load += new System.EventHandler(this.frmLoaiKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcLoaiKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLoaiKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchAccount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTenNuoc;
        private System.Windows.Forms.TextBox txtMaQT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnCapNhat;
        private DevExpress.XtraEditors.SimpleButton btnThemMoi;
        private System.Windows.Forms.Label lblThongtin;
        private DevExpress.XtraGrid.GridControl gcLoaiKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLoaiKhach;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSearchAccount;
    }
}