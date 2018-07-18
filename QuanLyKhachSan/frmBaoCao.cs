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
using DevExpress.XtraReports.UI;

namespace QuanLyKhachSan
{
    public partial class frmBaoCao : DevExpress.XtraEditors.XtraForm
    {
        public frmBaoCao()
        {
            InitializeComponent();
            DateTime today = DateTime.Now;
            deFromDate.EditValue = new DateTime(today.Year, today.Month, 1);
            deToDate.EditValue = deFromDate.DateTime.AddMonths(1).AddDays(-1);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
                    HoaDonTheoPhong crLP = new HoaDonTheoPhong();
                    crLP.DataSource= hoaDonBUS.Instance.LayThongTinHoaDonLoaiP((DateTime)deFromDate.EditValue, (DateTime)deToDate.EditValue);
                    ReportPrintTool tool = new ReportPrintTool(crLP);
                    tool.ShowPreview();
        }
    }
}