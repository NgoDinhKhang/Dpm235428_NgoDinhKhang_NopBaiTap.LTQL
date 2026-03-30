using BusinessLogicLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frm_dmNhanVien : Form
    {
        public frm_dmNhanVien()
        {
            InitializeComponent();
        }

        private void frm_dmNhanVien_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Hiển thị danh sách chức vụ lên ComboBox
                List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
                if (lstChucVu != null)
                {
                    cboChucVu.DataSource = lstChucVu;
                    cboChucVu.DisplayMember = "STenCV"; // Hiện tên chức vụ cho người dùng chọn
                    cboChucVu.ValueMember = "SMaCV";    // Giữ mã chức vụ ẩn bên dưới để lưu CSDL
                }

                // 2. Hiển thị danh sách nhân viên lên DataGridView
                List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
                if (lstNhanVien != null)
                {
                    dgvDSNhanVien.DataSource = lstNhanVien;


                    dgvDSNhanVien.Columns["SMaNV"].HeaderText = "Mã số";
                    dgvDSNhanVien.Columns["SHoLot"].HeaderText = "Họ và lót";
                    dgvDSNhanVien.Columns["STenNV"].HeaderText = "Tên";
                    dgvDSNhanVien.Columns["SPhai"].HeaderText = "Phái";
                    dgvDSNhanVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
                    dgvDSNhanVien.Columns["STenCV"].HeaderText = "Chức vụ";

                    // Ẩn cột Mã chức vụ đi cho gọn mắt
                    dgvDSNhanVien.Columns["SMaCV"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữ liệu: " + ex.Message);
            }
        }

        private void dgvDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvDSNhanVien.Rows[e.RowIndex];


                txtMaNV.Text = row.Cells["SMaNV"].Value.ToString();
                txtHoLot.Text = row.Cells["SHoLot"].Value.ToString();
                txtTen.Text = row.Cells["STenNV"].Value.ToString();


                cboChucVu.SelectedValue = row.Cells["SMaCV"].Value.ToString();


                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["DtNgaySinh"].Value);


                string phai = row.Cells["SPhai"].Value.ToString();
                if (phai.Trim() == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
            }
        }
        void HienThiDSNhanVienLenDatagrid()
        {

            dgvDSNhanVien.DataSource = NhanVien_BUS.LayNhanVien();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu có bị bỏ trống
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STenNV = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();
            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }

            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm nhân viên.");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STenNV = txtTen.Text;
            nv.SPhai = radNam.Checked ? "Nam" : "Nữ";
            nv.DtNgaySinh = dtpNgaySinh.Value;
            nv.SMaCV = cboChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.SuaNhanVien(nv))
            {
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin nhân viên.");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = txtMaNV.Text;

                if (NhanVien_BUS.XoaNhanVien(nv))
                {
                    HienThiDSNhanVienLenDatagrid(); // Load lại bảng
                    MessageBox.Show("Xóa thành công!");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            string ho = txtTimHo.Text.Trim();
            string ten = txtTimTen.Text.Trim();

            DataTable dt = NhanVien_BUS.TimKiemNhanVien(ho, ten);

            if (dt.Rows.Count > 0)
            {
                dgvDSNhanVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào khớp với từ khóa!");
                // Nếu không tìm thấy, có thể load lại toàn bộ danh sách
                HienThiDSNhanVienLenDatagrid();
            }


        }
    }
}
