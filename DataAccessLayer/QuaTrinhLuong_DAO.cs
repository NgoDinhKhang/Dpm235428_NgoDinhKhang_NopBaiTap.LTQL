using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class QuaTrinhLuong_DAO
    {
        public static DataTable TimKiemQuaTrinhLuong(DateTime tuNgay, DateTime denNgay)
        {
            string sTuNgay = tuNgay.ToString("yyyy-MM-dd");
            string sDenNgay = denNgay.ToString("yyyy-MM-dd");

            string sTruyVan = string.Format("SELECT * FROM quatrinhluong WHERE ngaybd BETWEEN '{0}' AND '{1}'", sTuNgay, sDenNgay);

            SqlConnection kn = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, kn);
            DataProvider.DongKetNoi(kn);
            return dt;
        }
    }
}
