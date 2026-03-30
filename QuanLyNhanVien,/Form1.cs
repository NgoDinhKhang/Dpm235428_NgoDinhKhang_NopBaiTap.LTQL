using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            // Dữ liệu combobox Chức vụ
            string sQueryChucVu = @"select * from chucvu";
            daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");
            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";
            // Dữ liệu datagrid Danh sách nhân viên
            string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgvNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
            dgvNhanVien.Columns["manv"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["manv"].Width = 60;
            dgvNhanVien.Columns["holot"].HeaderText = "Họ và tên lót";
            dgvNhanVien.Columns["holot"].Width = 150;
            dgvNhanVien.Columns["tennv"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["tennv"].Width = 70;
            dgvNhanVien.Columns["phai"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["phai"].Width = 50;
            dgvNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["ngaysinh"].Width = 80;
            dgvNhanVien.Columns["tencv"].HeaderText = "Chức vụ";
            dgvNhanVien.Columns["macv"].Visible = false;
            dgvNhanVien.Columns["macv"].Width = 70;

            string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai,
@NgaySinh, @MaCV)";
            SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
            cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
            cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
            cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
            cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
            cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10,
            "ngaysinh");
            cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");
            daNhanVien.InsertCommand = cmThemNV;
        }

        private void dgvNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgvNhanVien.SelectedRows[0];
            txtMaNV.Text = dr.Cells["manv"].Value.ToString();
            txtHoLot.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")

            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) ||
        string.IsNullOrWhiteSpace(txtHoLot.Text) ||
        string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin (Mã, Họ lót, Tên)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            string maNV = txtMaNV.Text;
            DataRow[] kiemTraTrung = ds.Tables["tblDSNhanVien"].Select($"manv = '{maNV}'");

            if (kiemTraTrung.Length > 0)
            {
                MessageBox.Show("Mã nhân viên này đã tồn tại! Vui lòng nhập mã khác.", "Lỗi trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.SelectAll();
                txtMaNV.Focus();
                return;
            }

            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMaNV.Text;
            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtTen.Text;
            if (radNu.Checked == true)
            {
                row["phai"] = "Nữ";
            }
            else
            {
                row["phai"] = "Nam";
            }
            row["ngaysinh"] = dtpNgaySinh.Value;
            row["macv"] = cboChucVu.SelectedValue;
            ds.Tables["tblDSNhanVien"].Rows.Add(row);

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa trên danh sách!", "Thông báo");
                return;
            }

            // Lấy Mã NV từ dòng đang chọn trên lưới (để tìm trong DataTable)
            string maNVCun = dgvNhanVien.CurrentRow.Cells["manv"].Value.ToString();

            // Tìm dòng dữ liệu tương ứng trong DataTable
            // Lưu ý: Cần set PrimaryKey cho DataTable trước đó, hoặc dùng hàm Select
            DataRow row = ds.Tables["tblDSNhanVien"].Rows.Find(maNVCun);

            if (row != null)
            {
                // Cập nhật lại các thông tin (trừ Mã NV thường không cho sửa)
                row["holot"] = txtHoLot.Text;
                row["tennv"] = txtTen.Text;

                if (radNu.Checked) row["phai"] = "Nữ";
                else row["phai"] = "Nam";

                row["ngaysinh"] = dtpNgaySinh.Value;
                row["macv"] = cboChucVu.SelectedValue;

                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra chọn dòng
            if (dgvNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo");
                return;
            }

            // Hỏi xác nhận (Rất quan trọng)
            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?",
                                              "Xác nhận xóa",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // Lấy Mã NV dòng hiện tại
                string maNV = dgvNhanVien.CurrentRow.Cells["manv"].Value.ToString();

                // Tìm và xóa trong DataTable
                DataRow row = ds.Tables["tblDSNhanVien"].Rows.Find(maNV);
                if (row != null)
                {
                    row.Delete(); // Đánh dấu dòng này là "Deleted"
                }
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder cb = new SqlCommandBuilder(daChucVu);

                // Cập nhật thay đổi về CSDL
                daChucVu.Update(ds, "tblDSNhanVien");

                MessageBox.Show("Đã lưu thay đổi vào Cơ sở dữ liệu!", "Thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Hàm RejectChanges sẽ khôi phục lại dữ liệu như lúc mới load 
            // hoặc lúc vừa Save lần cuối.
            ds.Tables["tblDSNhanVien"].RejectChanges();

            MessageBox.Show("Đã hủy các thay đổi chưa lưu.", "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát chương trình?",
                                              "Xác nhận",
                                              MessageBoxButtons.YesNo,
                                              MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
