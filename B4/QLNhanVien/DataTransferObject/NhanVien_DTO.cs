using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class NhanVien_DTO
    {
        public string SMaNV { get; set; }
        public string SHoLot { get; set; }
        public string STenNV { get; set; }
        public string SPhai { get; set; }
        public DateTime DtNgaySinh { get; set; }
        public string SMaCV { get; set; }
        public string STenCV { get; set; }
    }
}
