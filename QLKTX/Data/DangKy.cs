using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Data
{
    public class DangKy
    {
        public int ID { get; set; }

        public int SinhVienID { get; set; }
        public int PhongID { get; set; }

        public DateTime NgayVao { get; set; }
        public DateTime? NgayRa { get; set; }

        public virtual SinhVien SinhVien { get; set; } = null!;
        public virtual Phong Phong { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachDangKy
    {
        public int ID { get; set; }
        public string MaSV { get; set; }
        public string TenSinhVien { get; set; }
        public string TenPhong { get; set; }
        public DateTime NgayVao { get; set; }
    }
}
