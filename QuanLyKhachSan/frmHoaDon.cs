using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BUS;
using DTO;
using System.Globalization;
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan
{
    public partial class frmHoaDon : DevExpress.XtraEditors.XtraForm
    {
        public frmHoaDon()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            deFromDate.EditValue = new DateTime(today.Year, today.Month, 1);
            deToDate.EditValue = deFromDate.DateTime.AddMonths(1).AddDays(-1);
        }
        void loadDSHoaDon(DateTime tuNgay, DateTime denNgay)
        {
            double TongTien = 0;
            List<HoaDonDTO> list = hoaDonBUS.Instance.layDanhSachHoaDonbyKhoanThoiGian(tuNgay, denNgay);
            gcBill.DataSource = list;
            foreach (HoaDonDTO item in list)
            {
                TongTien += item.TongTien;
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            lblTongTien.Text = TongTien.ToString("c", culture);
            gvBill.Columns[0].Caption = "Mã hóa đơn";
            gvBill.Columns[1].Visible = false;
            gvBill.Columns[2].Caption = "Nhân viên";
            gvBill.Columns[3].Caption = "Số ngày thuê";
            gvBill.Columns[3].DisplayFormat.FormatString = "0.##";
            gvBill.Columns[4].Caption = "Thời gian";
            gvBill.Columns[5].Caption = "Tổng tiền";
            gvBill.Columns[5].DisplayFormat.FormatString = "#,###";
            gvBill.Columns[6].Caption = "Phòng";
        }
        private void btnShowBill_Click(object sender, EventArgs e)
        {
            loadDSHoaDon((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string MAHD = (string)gvBill.GetRowCellValue(gvBill.FocusedRowHandle, gvBill.Columns[0]);
            ReportHoaDon report = new ReportHoaDon();
            report.DataSource = hoaDonBUS.Instance.LayThongTinHoaDon(MAHD);
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreview();
        }
    }
}