using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static DoAnWeb.Models.ModelDbContext;
namespace DoAnWeb.Models
{
    public class HomeModel
    {
       
        public List<SanPham> ListSP { get; set; }
        public List<LoaiSanPham> ListLSP { get; set; }
        public List<NhaSanXuat> ListNSX { get; set; }
    }
}