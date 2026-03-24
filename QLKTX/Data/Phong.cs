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
    public class Phong
    {


        public int ID { get; set; }

        public string MaPhong { get; set; } = null!; //

        public int ToaNhaID { get; set; }
        public int LoaiPhongID { get; set; }

        public string TenPhong { get; set; }
        public int GiaPhong { get; set; }
        public int SucChua { get; set; }
        public int SoLuongHienTai { get; set; }

        public virtual ToaNha ToaNha { get; set; } = null!;
        public virtual LoaiPhong LoaiPhong { get; set; } = null!;

        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();
    }
    [NotMapped]
    public class DanhSachPhong
    {
        public int ID { get; set; }
        [Required]
        public string MaPhong { get; set; } = null!; //
        public int ToaNhaID { get; set; }
        public int LoaiPhongID { get; set; }

        public string TenPhong { get; set; }
        public int GiaPhong { get; set; }
        public int SucChua { get; set; }
        public int SoLuongHienTai { get; set; }

        public virtual ToaNha ToaNha { get; set; } = null!;
        public virtual LoaiPhong LoaiPhong { get; set; } = null!;

        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();
    }
}
