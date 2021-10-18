namespace QLKSHOANGLONG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        [Key]
        public int IDNhanVien { get; set; }

        [StringLength(50)]
        public string TenNV { get; set; }

        public int? SDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }

        public virtual LichLamViec LichLamViec { get; set; }
    }
    public partial class NhanVien
    {
        public static List<NhanVien> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.NhanViens.ToList();
        }
        public static NhanVien GetNhanVien(int IdNhanVien)
        {
            QLKSModel context = new QLKSModel();
            return context.NhanViens.Where(p => p.IDNhanVien == IdNhanVien).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.NhanViens.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLKSModel context = new QLKSModel();
            NhanVien db = context.NhanViens.Where(p => p.IDNhanVien == id).FirstOrDefault();
            if (db != null)
            {
                context.NhanViens.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
