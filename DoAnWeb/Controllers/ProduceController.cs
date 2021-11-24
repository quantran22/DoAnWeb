using DoAnWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAnWeb.Controllers
{
    public class ProduceController : Controller
    {
        ModelDbContext DbModelDbContext = new ModelDbContext();
        // GET: Produce
        public ActionResult Detail(string ID)
        {
            var Istcategory = DbModelDbContext.NhaSanXuat.Where(n => n.MaNhaSanXuat == ID).FirstOrDefault();
            return View(Istcategory);
        }
    }
}