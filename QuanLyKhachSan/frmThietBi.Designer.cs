namespace QuanLyKhachSan
{
    partial class frmThietBi
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
            this.lblTemp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsvDSThietBi = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaThietbi = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTemp.Location = new System.Drawing.Point(333, 12);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(0, 13);
            this.lblTemp.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lsvDSThietBi);
            this.panel1.Controls.Add(this.txtTenThietBi);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMaThietbi);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.txtTim);
            this.panel1.Location = new System.Drawing.Point(110, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 386);
            this.panel1.TabIndex = 19;
            // 
            // lsvDSThietBi
            // 
            this.lsvDSThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvDSThietBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lsvDSThietBi.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvDSThietBi.GridLines = true;
            this.lsvDSThietBi.Location = new System.Drawing.Point(10, 172);
            this.lsvDSThietBi.Name = "lsvDSThietBi";
            this.lsvDSThietBi.Size = new System.Drawing.Size(357, 206);
            this.lsvDSThietBi.TabIndex = 44;
            this.lsvDSThietBi.UseCompatibleStateImageBehavior = false;
            this.lsvDSThietBi.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã thiết bị";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên Thiết bị";
            this.columnHeader2.Width = 188;
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(118, 57);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(173, 21);
            this.txtTenThietBi.TabIndex = 7;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(182, 98);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(80, 40);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên Thiết Bị";
            // 
            // txtMaThietbi
            // 
            this.txtMaThietbi.Location = new System.Drawing.Point(118, 30);
            this.txtMaThietbi.Name = "txtMaThietbi";
            this.txtMaThietbi.Size = new System.Drawing.Size(173, 21);
            this.txtMaThietbi.TabIndex = 6;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(96, 98);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(80, 40);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên thiết bị:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã thiết bị:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 98);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(80, 40);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(241, 143);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(57, 23);
            this.btnTim.TabIndex = 1;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(75, 144);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(160, 21);
            this.txtTim.TabIndex = 0;
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTemp);
            this.Name = "frmThietBi";
            this.Text = "Thiết Bị";
            this.Load += new System.EventHandler(this.frmThietBi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lsvDSThietBi;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaThietbi;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
    }
}