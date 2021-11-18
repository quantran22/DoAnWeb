

using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class HomeController : Controller
    {
        ModelDbContext DbModelDbContext = new ModelDbContext();
        public ActionResult Index()
        {
            HomeModel DbHomeModel = new HomeModel();

            DbHomeModel.ListNSX = DbModelDbContext.NhaSanXuat.ToList();
            DbHomeModel.ListLSP = DbModelDbContext.LoaiSanPham.ToList();
            DbHomeModel.ListSP = DbModelDbContext.SanPham.ToList();
            return View(DbHomeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}