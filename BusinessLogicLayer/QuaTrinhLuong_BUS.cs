using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class QuaTrinhLuong_BUS
    {
        public static DataTable TimKiemQuaTrinhLuong(DateTime tuNgay, DateTime denNgay)
        {
            return QuaTrinhLuong_DAO.TimKiemQuaTrinhLuong(tuNgay, denNgay);
        }
    }
}
