namespace QuanLyKhachSan
{
    partial class frmKhachHang
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.gcDsKhach = new DevExpress.XtraGrid.GridControl();
            this.gvDsKhach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.txtSearchAccount = new DevExpress.XtraEditors.TextEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.cbQuocTich = new System.Windows.Forms.ComboBox();
            this.lblCmnd = new System.Windows.Forms.Label();
            this.lblgioitinhtemp = new System.Windows.Forms.Label();
            this.lblLoaiKhach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gcDsKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchAccount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gcDsKhach
            // 
            gridLevelNode2.RelationName = "Level1";
            this.gcDsKhach.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gcDsKhach.Location = new System.Drawing.Point(2, 70);
            this.gcDsKhach.MainView = this.gvDsKhach;
            this.gcDsKhach.Name = "gcDsKhach";
            this.gcDsKhach.Size = new System.Drawing.Size(542, 435);
            this.gcDsKhach.TabIndex = 0;
            this.gcDsKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDsKhach});
            // 
            // gvDsKhach
            // 
            this.gvDsKhach.GridControl = this.gcDsKhach;
            this.gvDsKhach.Name = "gvDsKhach";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(742, 130);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 42;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(689, 130);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(46, 17);
            this.rdNam.TabIndex = 41;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(555, 134);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(49, 13);
            this.lblGioiTinh.TabIndex = 52;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(688, 179);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(216, 21);
            this.txtDiachi.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Quốc tịch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(555, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Địa chỉ:";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(688, 153);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(216, 21);
            this.txtSoDienThoai.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(555, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Số điện thoại:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(688, 104);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(216, 21);
            this.txtHoTen.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "Họ tên:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(688, 78);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(216, 21);
            this.txtCMND.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Chứng minh nhân dân:";
            // 
            // btnSearch
            // 
            this.btnSearch.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Appearance.Options.UseFont = true;
            this.btnSearch.Location = new System.Drawing.Point(188, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 35);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchAccount
            // 
            this.txtSearchAccount.EditValue = "";
            this.txtSearchAccount.Location = new System.Drawing.Point(2, 35);
            this.txtSearchAccount.Name = "txtSearchAccount";
            this.txtSearchAccount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAccount.Properties.Appearance.Options.UseFont = true;
            this.txtSearchAccount.Properties.NullText = "-- Tìm tên nhân viên --";
            this.txtSearchAccount.Properties.NullValuePrompt = "-- Tìm tên nhân viên --";
            this.txtSearchAccount.Size = new System.Drawing.Size(180, 24);
            this.txtSearchAccount.TabIndex = 90;
            this.txtSearchAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchAccount_KeyDown);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(664, 244);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(79, 35);
            this.btnThem.TabIndex = 91;
            this.btnThem.Text = "Thêm Mới";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(745, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(79, 35);
            this.btnUpdate.TabIndex = 91;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(825, 244);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 35);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbQuocTich
            // 
            this.cbQuocTich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQuocTich.FormattingEnabled = true;
            this.cbQuocTich.Location = new System.Drawing.Point(689, 206);
            this.cbQuocTich.Name = "cbQuocTich";
            this.cbQuocTich.Size = new System.Drawing.Size(216, 21);
            this.cbQuocTich.TabIndex = 45;
            // 
            // lblCmnd
            // 
            this.lblCmnd.Location = new System.Drawing.Point(562, 326);
            this.lblCmnd.Name = "lblCmnd";
            this.lblCmnd.Size = new System.Drawing.Size(0, 13);
            this.lblCmnd.TabIndex = 92;
            this.lblCmnd.Text = "label5";
            // 
            // lblgioitinhtemp
            // 
            this.lblgioitinhtemp.Location = new System.Drawing.Point(635, 325);
            this.lblgioitinhtemp.Name = "lblgioitinhtemp";
            this.lblgioitinhtemp.Size = new System.Drawing.Size(0, 23);
            this.lblgioitinhtemp.TabIndex = 93;
            this.lblgioitinhtemp.Text = "label6";
            this.lblgioitinhtemp.TextChanged += new System.EventHandler(this.lblgioitinhtemp_TextChanged);
            // 
            // lblLoaiKhach
            // 
            this.lblLoaiKhach.Location = new System.Drawing.Point(605, 389);
            this.lblLoaiKhach.Name = "lblLoaiKhach";
            this.lblLoaiKhach.Size = new System.Drawing.Size(0, 13);
            this.lblLoaiKhach.TabIndex = 92;
            this.lblLoaiKhach.Text = "label5";
            this.lblLoaiKhach.TextChanged += new System.EventHandler(this.lblLoaiKhach_TextChanged);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 507);
            this.Controls.Add(this.lblgioitinhtemp);
            this.Controls.Add(this.lblLoaiKhach);
            this.Controls.Add(this.lblCmnd);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchAccount);
            this.Controls.Add(this.cbQuocTich);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoDienThoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gcDsKhach);
            this.Name = "frmKhachHang";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcDsKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDsKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchAccount.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcDsKhach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDsKhach;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraEditors.TextEdit txtSearchAccount;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.ComboBox cbQuocTich;
        private System.Windows.Forms.Label lblCmnd;
        private System.Windows.Forms.Label lblgioitinhtemp;
        private System.Windows.Forms.Label lblLoaiKhach;
    }
}