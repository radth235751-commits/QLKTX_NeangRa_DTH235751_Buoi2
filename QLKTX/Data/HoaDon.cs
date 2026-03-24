using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Data
{
    public class HoaDon
    {
        public int ID { get; set; }

        public int SinhVienID { get; set; }
        public int NhanVienID { get; set; }

        public DateTime NgayLap { get; set; }
        public string? GhiChu { get; set; }

        public virtual SinhVien SinhVien { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;

        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();
    }
    [NotMapped]
    public class DanhSachHoaDon
    {
        public int ID { get; set; }
        public string TenSinhVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgayLap { get; set; }
    }
}
