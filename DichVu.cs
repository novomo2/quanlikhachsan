namespace QLKSHOANGLONG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        public int IDDichVu { get; set; }

        [StringLength(50)]
        public string TenDV { get; set; }

        public int? GiaDV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }
    }
    public partial class DichVu
    {
        public int SoLuong = 0;
        public int ThanhTien = 0;

        public static List<DichVu> GetAll()
        {
            QLKSModel context = new QLKSModel();
            return context.DichVus.ToList();
        }
        public static DichVu GetDichVu(int Iddichvu)
        {
            QLKSModel context = new QLKSModel();
            return context.DichVus.Where(p => p.IDDichVu == Iddichvu).FirstOrDefault();

        }
        public void InsertUpdate()
        {
            QLKSModel context = new QLKSModel();
            context.DichVus.AddOrUpdate(this);
            context.SaveChanges();
        }

        public static void Delete(int id)
        {
            QLKSModel context = new QLKSModel();
            DichVu db = context.DichVus.Where(p => p.IDDichVu == id).FirstOrDefault();
            if (db != null)
            {
                context.DichVus.Remove(db);
                context.SaveChanges();
            }
            else
                throw new Exception("Khong ton tai trong csdl");
        }
    }
}
