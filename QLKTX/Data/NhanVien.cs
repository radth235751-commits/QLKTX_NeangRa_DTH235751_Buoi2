using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        [Required]
        public string? MaNV { get; set; } = null!; //
        public string? HoVaTen { get; set; }
        public string? TenDangNhap { get; set; }
        public string? MatKhau { get; set; }
        public bool? QuyenHan { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }

        public string? GioiTinh { get; set; } = "";

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
    [NotMapped]
    public class DanhSachNhanVien
    {
        public int ID { get; set; }
        public string? MaNV { get; set; } = null!;
        public string? HoVaTen { get; set; }
        public string? TenDangNhap { get; set; }
        public bool? QuyenHan { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? GioiTinh { get; set; } = "";

    }
}
