using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

namespace DataAccessLayer
{
    public class NhanVien_DAO
    {
        static SqlConnection con;

        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "SELECT n.*, c.tencv FROM nhanvien n JOIN chucvu c ON n.macv = c.macv";

            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STenNV = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.DtNgaySinh = Convert.ToDateTime(dt.Rows[i]["ngaysinh"]);
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                nv.STenCV = dt.Rows[i]["tencv"].ToString(); 

                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"insert into nhanvien values(N’{ 0}’,
N’{ 1}’,N’{ 2}’,N’{ 3}’,’{ 4}’,N’{ 5}’)", nv.SMaNV, nv.SHoLot, nv.STenNV, nv.SPhai,
nv.DtNgaySinh, nv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        // Lấy thông tin nhân viên có mã ma, trả về null nếu không thấy
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv=N'{0}'",
            ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = dt.Rows[0]["manv"].ToString();
            nv.SHoLot = dt.Rows[0]["holot"].ToString();
            nv.STenNV = dt.Rows[0]["tennv"].ToString();
            nv.SPhai = dt.Rows[0]["phai"].ToString();
            nv.DtNgaySinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.SMaCV = dt.Rows[0]["macv"].ToString();
            DataProvider.DongKetNoi(con);
            return nv;
        }
        // Hàm Sửa nhân viên
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            
            string sTruyVan = string.Format("UPDATE NhanVien SET HoLot = N'{0}', Ten = N'{1}', Phai = N'{2}', NgaySinh = '{3}', MaCV = '{4}' WHERE MaNV = '{5}'",
                              nv.SHoLot, nv.STenNV, nv.SPhai, nv.DtNgaySinh.ToString("yyyy-MM-dd"), nv.SMaCV, nv.SMaNV);

            SqlConnection kn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, kn);
            DataProvider.DongKetNoi(kn);
            return kq;
        }

        
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format("DELETE FROM NhanVien WHERE MaNV = '{0}'", nv.SMaNV);

            SqlConnection kn = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, kn);
            DataProvider.DongKetNoi(kn);
            return kq;
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like
'%{0}%'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STenNV = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
        public static DataTable TimKiemNhanVien(string ho, string ten)
        {
            
            string sTruyVan = string.Format("SELECT * FROM NhanVien WHERE HoLot LIKE N'%{0}%' AND Ten LIKE N'%{1}%'", ho, ten);

            SqlConnection kn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, kn);
            DataProvider.DongKetNoi(kn);
            return dt;
        }
    }   
}