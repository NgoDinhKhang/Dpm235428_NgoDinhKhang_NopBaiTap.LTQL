using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuoiTH03
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
            conn.ConnectionString = @"Data Source=(local);Initial Catalog=QLNV;Integrated
Security=True";
            // Dữ liệu combobox Chức vụ
            string sQueryChucVu = @"select * from chucvu";
            daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
            daChucVu.Fill(ds, "tblChucVu");
            cboChucVu.DataSource = ds.Tables["tblChucVu"];
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";
            // Dữ liệu datagrid Danh sách nhân viên
            string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where
n.macv=c.macv";
            daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
            daNhanVien.Fill(ds, "tblDSNhanVien");
            dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];
            dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
            dgDSNhanVien.Columns["manv"].Width = 60;
            // ... đặt tiêu đề tiếng Việt, định độ rộng cho các trường còn lại
            dgDSNhanVien.Columns["macv"].Visible = false;
            // Command Thêm nhân viên
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
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
            row["ngaysinh"] = dtpNgaySinh.Text;
            row["macv"] = cboChucVu.SelectedValue;
            ds.Tables["tblDSNhanVien"].Rows.Add(row);
            try
            {
                ds.Tables["tblDSNhanVien"].Rows.Add(row);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mã nhân viên cõ thể bị trùng:" + ex.Message);

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow dgvRow in dgDSNhanVien.SelectedRows)
                {
                    if (dgvRow.IsNewRow) continue;
                    DataRowView drv = dgvRow.DataBoundItem as DataRowView;
                    if (drv != null)
                    {
                        drv.Row.Delete();
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cân xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cân sửa!");
                return;
            }
            int index = dgDSNhanVien.CurrentRow.Index;
            DataRow row = ds.Tables["tblDSNhanVien"].Rows[index];
            row.BeginEdit();
            row["manv"] = txtMaNV.Text;
            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtTen.Text;
            row["phai"] = radNam.Checked ? "Nam" : "Nu";
            row["ngaysinh"] = dtpNgaySinh.Value;
            row["macv"] = cboChucVu.SelectedValue;
            row.EndEdit();
            MessageBox.Show("Đã cập nhật vào bộ nhớ tạm ( hãy bấm lưu vào csdl).");                         
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                daNhanVien.Update(ds, "tblDSNhanVien");
                MessageBox.Show("Đã lưu thành công vào cơ sở dữ diệu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỖI khi lưu:" + ex.Message);
            } 

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}