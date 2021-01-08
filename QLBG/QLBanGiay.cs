using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLBG
{
    public partial class QLBanGiay : DbContext
    {
        public QLBanGiay()
            : base("name=QLBanGiay")
        {
        }

        public virtual DbSet<Hoadonban> Hoadonbans { get; set; }
        public virtual DbSet<Hoadonnhap> Hoadonnhaps { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hoadonban>()
                .Property(e => e.MaHDB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonban>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonban>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonban>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonban>()
                .Property(e => e.Diachi)
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonnhap>()
                .Property(e => e.MaHDN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonnhap>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonnhap>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonnhap>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hoadonnhap>()
                .Property(e => e.Diachi)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKH)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.Hoadonbans)
                .WithOptional(e => e.KhachHang)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.TenNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .HasMany(e => e.Hoadonnhaps)
                .WithOptional(e => e.NhaCC)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Hoadonbans)
                .WithOptional(e => e.NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Hoadonnhaps)
                .WithOptional(e => e.NhanVien)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaSP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.TenSP)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.MaNCC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.Hoadonbans)
                .WithOptional(e => e.SanPham)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.Hoadonnhaps)
                .WithOptional(e => e.SanPham)
                .WillCascadeOnDelete();
        }
    }
}
