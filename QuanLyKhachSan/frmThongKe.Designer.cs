namespace QuanLyKhachSan
{
    partial class frmThongKe
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyKhachSanDataSet1 = new QuanLyKhachSan.QuanLyKhachSanDataSet();
            this.hoadonTableAdapter1 = new QuanLyKhachSan.QuanLyKhachSanDataSetTableAdapters.HOADONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.hoadonTableAdapter1;
            this.chartControl1.DataSource = this.hOADONBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Title.Text = "Doanh Thu (VNĐ)";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Legend.TextVisible = false;
            this.chartControl1.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesDataMember = "NgayThanhToan";
            series1.ArgumentDataMember = "NgayThanhToan";
            series1.Name = "Doanh Thu";
            series1.ValueDataMembersSerializable = "TongTien";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.SeriesTemplate.ArgumentDataMember = "TongTien";
            this.chartControl1.SeriesTemplate.Visible = false;
            this.chartControl1.Size = new System.Drawing.Size(886, 606);
            this.chartControl1.TabIndex = 0;
            chartTitle1.Text = "Thống kê doanh thu ";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.quanLyKhachSanDataSet1;
            this.hOADONBindingSource.Sort = "";
            // 
            // quanLyKhachSanDataSet1
            // 
            this.quanLyKhachSanDataSet1.DataSetName = "QuanLyKhachSanDataSet";
            this.quanLyKhachSanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoadonTableAdapter1
            // 
            this.hoadonTableAdapter1.ClearBeforeFill = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 606);
            this.Controls.Add(this.chartControl1);
            this.Name = "frmThongKe";
            this.Text = "Thống Kê";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKhachSanDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private QuanLyKhachSanDataSetTableAdapters.HOADONTableAdapter hoadonTableAdapter1;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private QuanLyKhachSanDataSet quanLyKhachSanDataSet1;
    }
}