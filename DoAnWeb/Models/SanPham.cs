namespace DoAnWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [Key]

        public int? MaSanPham { get; set; }

        [StringLength(10)]
        public string MaLoaiSanPham { get; set; }

        [StringLength(10)]
        public string MaNhaSanXuat { get; set; }

        public string TenSanPham { get; set; }

        [Column(TypeName = "text")]
        public string CauHinh { get; set; }

        [StringLength(50)]
        public string HinhChinh { get; set; }

        [StringLength(50)]
        public string Hinh1 { get; set; }

        [StringLength(50)]
        public string Hinh2 { get; set; }

        [StringLength(50)]
        public string Hinh3 { get; set; }

        [StringLength(50)]
        public string Hinh4 { get; set; }

        public int? Gia { get; set; }

        public int? SoLuongBan { get; set; }

        public int? LuotView { get; set; }

        [StringLength(10)]
        public string TinhTrang { get; set; }
    }
}
