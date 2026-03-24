using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Data
{
    public class LoaiPhong
    {
        public int ID { get; set; }
        public string TenLoai { get; set; }

        public virtual ObservableCollectionListSource<Phong> Phong { get; } = new();
    }
}
