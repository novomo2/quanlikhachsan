namespace QLKSHOANGLONG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("ThongKe")]
    public partial class ThongKe
    {
        [Key]
        public int IDThongKe { get; set; }

        [StringLength(15)]
        public string NgayBD { get; set; }

        [StringLength(15)]
        public string NgayKT { get; set; }

        public int? IDHoaDon { get; set; }

        public int? TongDoanhThu { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
    public partial class ThongKe
    {
        public static List<ThongKe> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.ThongKes.ToList();
        }
        public static ThongKe GetThongKe(int IdThongKe)
        {
            QLKSModel context = new QLKSModel();
            return context.ThongKes.Where(p => p.IDThongKe == IdThongKe).FirstOrDefault();

        }
        public ThongKe InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            ThongKe tk = context.ThongKes.Add(this);
            context.SaveChanges();
            return tk;
        }
    }
}
