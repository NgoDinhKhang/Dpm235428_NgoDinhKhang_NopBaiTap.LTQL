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
    }
}