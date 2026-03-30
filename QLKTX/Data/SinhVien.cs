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
    public partial class SinhVien
    {
        public int ID { get; set; }

        [Required]
        public string MaSV { get; set; } = null!;

        [Required]
        public string HoVaTen { get; set; }

        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }

        public string? Khoa { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public bool? Phai { get; set; }

        public string? HinhAnh { get; set; }

        // Quan hệ
        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();

        public virtual ObservableCollectionListSource<DangKy> DangKy { get; } = new();
    }
    [NotMapped]
    public class DanhSachSinhVien
    {
        public int ID { get; set; }
        public string? MaSV { get; set; }
        public string? HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? Khoa { get; set; }
        public string? Email { get; set; }
        public string? Phai { get; set; }
        public string? DiaChi { get; set; }
        public string? HinhAnh { get; set; }// Nam / Nữ

        [NotMapped]
        public Image Anh
        {
            get
            {
                try
                {
                    if (!string.IsNullOrEmpty(HinhAnh) && File.Exists(HinhAnh))
                        return Image.FromFile(HinhAnh);
                }
                catch { }
                return null;
            }
        }
    }
}
    
    

