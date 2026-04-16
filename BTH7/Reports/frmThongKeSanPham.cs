using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTH1.Data;
using BTH1.Reports;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace BTH1.Reports
{
    public partial class frmThongKeSanPham : Form
    {
        QLBHDbContext context = new QLBHDbContext();
        QLBHDataSet.DanhSachSanPhamDataTable danhSachSanPhamDataTable = new QLBHDataSet.DanhSachSanPhamDataTable();
        string reportsFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Reports");

        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {
            var danhSachSanPham = context.SanPham.Select(r => new DanhSachSanPham
            {
                ID = r.ID,
                HangSanXuatID = r.HangSanXuatID,
                TenHangSanXuat = r.HangSanXuat.TenHangSanXuat,
                LoaiSanPhamID = r.LoaiSanPhamID,
                TenLoai = r.LoaiSanPham.TenLoai,
                TenSanPham = r.TenSanPham,
                DonGia = r.DonGia,
                SoLuong = r.SoLuong,
                HinhAnh = r.HinhAnh,
                MoTa = r.MoTa
            }).ToList();

            danhSachSanPhamDataTable.Clear();
            foreach (var row in danhSachSanPham)
            {
                danhSachSanPhamDataTable.AddDanhSachSanPhamRow(row.ID,
                 row.HangSanXuatID,
                 row.TenHangSanXuat,
                 row.LoaiSanPhamID,
                 row.TenLoai,
                 row.TenSanPham,
                 row.DonGia,
                 row.SoLuong,
                 row.HinhAnh,
                 row.MoTa);
            }

            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DanhSachSanPham";
            reportDataSource.Value = danhSachSanPhamDataTable;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(reportDataSource);
            reportViewer.LocalReport.ReportPath = Path.Combine(reportsFolder, "rptThongKeSanPham.rdlc");

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;

            reportViewer.RefreshReport();
        }
    }
}