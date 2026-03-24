using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Data
{
    public class DienNuoc
    {
        public int ID { get; set; }

        public int PhongID { get; set; }

        public int Thang { get; set; }
        public int Nam { get; set; }

        public int SoDien { get; set; }
        public int SoNuoc { get; set; }

        public int DonGiaDien { get; set; }
        public int DonGiaNuoc { get; set; }

        public virtual Phong Phong { get; set; } = null!;
    }
    [NotMapped]
    public class DanhSachDienNuoc
    {
        public int ID { get; set; }
        public string TenPhong { get; set; }
        public int Thang { get; set; }
        public int SoDien { get; set; }
        public int SoNuoc { get; set; }
    }
}
