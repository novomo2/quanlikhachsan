using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKSHOANGLONG.Model
{
    public partial class QLKSModel : DbContext
    {
        public QLKSModel()
            : base("name=QLKSModel4")
        {
        }

        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<DatPhong> DatPhongs { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LichLamViec> LichLamViecs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<MatKhau> MatKhaus { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<ThongKe> ThongKes { get; set; }
        public virtual DbSet<VatTu> VatTus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TenKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.TenLoai)
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.NgayHD)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.QuocTich)
                .IsUnicode(false);

            modelBuilder.Entity<LichLamViec>()
                .Property(e => e.Ngay)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.TenLoai)
                .IsUnicode(false);

            modelBuilder.Entity<MatKhau>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<MatKhau>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasOptional(e => e.LichLamViec)
                .WithRequired(e => e.NhanVien);

            modelBuilder.Entity<ThongKe>()
                .Property(e => e.NgayBD)
                .IsUnicode(false);

            modelBuilder.Entity<ThongKe>()
                .Property(e => e.NgayKT)
                .IsUnicode(false);
        }
    }
}
