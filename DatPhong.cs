namespace QLKSHOANGLONG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("DatPhong")]
    public partial class DatPhong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatPhong()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int IDDatPhong { get; set; }

        [StringLength(50)]
        public string TenDatPhong { get; set; }

        public int? SDTDatPhong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
    public partial class DatPhong
    {
        public static List<DatPhong> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.DatPhongs.ToList();
        }
        public static DatPhong GetDatPhong(int IDDatphong)
        {
            QLKSModel context = new QLKSModel();
            return context.DatPhongs.Where(p => p.IDDatPhong == IDDatphong).FirstOrDefault();
        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.DatPhongs.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLKSModel context = new QLKSModel();
            DatPhong db = context.DatPhongs.Where(p => p.IDDatPhong == id).FirstOrDefault();
            if (db != null)
            {
                context.DatPhongs.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }

}
