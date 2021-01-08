namespace QLBG
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hoadonnhap")]
    public partial class Hoadonnhap
    {
        [Key]
        [StringLength(10)]
        public string MaHDN { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }

        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(10)]
        public string MaNCC { get; set; }

        public int? Soluong { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngayban { get; set; }

        [StringLength(50)]
        public string Diachi { get; set; }

        public int? sdt { get; set; }

        public double? Dongia { get; set; }

        public double? Tongtien { get; set; }

        public virtual NhaCC NhaCC { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
