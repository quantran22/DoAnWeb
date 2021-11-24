using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class ShopController : Controller
    {
        ModelDbContext Db = new ModelDbContext();
        // GET: Shop
        public ActionResult Sp()
        {
            var Istcategory = Db.SanPham.ToList();
            return View(Istcategory);
        }
        public ActionResult Detail( int MaSanPham)
        {
            var Istcategory = Db.SanPham.Where(n => n.MaSanPham == MaSanPham).FirstOrDefault();
            return View(Istcategory);
        }
    }
}