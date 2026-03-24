using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Data
{
    public class HoaDonChiTiet
    {
        public int ID { get; set; }

        public int HoaDonID { get; set; }
        public int PhongID { get; set; }

        public int SoThang { get; set; }
        public int DonGia { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual Phong Phong { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachHoaDonChiTiet
    {
        public int ID { get; set; }
        public string TenPhong { get; set; }
        public int SoThang { get; set; }
        public int DonGia { get; set; }
        public int ThanhTien { get; set; }
    }
}
