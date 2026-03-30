using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class frm_nvQuaTrinhLuong : Form
    {
        public frm_nvQuaTrinhLuong()
        {
            InitializeComponent();
            dgvQuaTrinhLuong.DataSource = QuaTrinhLuong_BUS.TimKiemQuaTrinhLuong(new DateTime(2000, 1, 1), DateTime.Now);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay;

            if (radDenHienTai.Checked)
            {
                denNgay = DateTime.Now; // Nếu chọn hiện tại, lấy ngày giờ máy tính
            }
            else
            {
                denNgay = dtpDenNgay.Value;
            }

            dgvQuaTrinhLuong.DataSource = QuaTrinhLuong_BUS.TimKiemQuaTrinhLuong(tuNgay, denNgay);
        }
    }
}
