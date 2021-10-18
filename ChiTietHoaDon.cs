namespace QLKSHOANGLONG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public int IDChiTietHoaDon { get; set; }

        public int? IDHoaDon { get; set; }

        public int? IDDichVu { get; set; }

        public int? GiaDV { get; set; }

        public int? SoLuong { get; set; }

        public int? ThanhTien { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
    public partial class ChiTietHoaDon
    {
        public static List<ChiTietHoaDon> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.ChiTietHoaDons.ToList();
        }
        public static ChiTietHoaDon GetChiTietHoaDon(int IDcthd)
        {
            QLKSModel context = new QLKSModel();
            return context.ChiTietHoaDons.Where(p => p.IDChiTietHoaDon == IDcthd).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.ChiTietHoaDons.AddOrUpdate(this);
            context.SaveChanges();
        }


    }
}
