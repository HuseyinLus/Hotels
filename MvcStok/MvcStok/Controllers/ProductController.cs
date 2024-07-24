using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;


namespace MvcStok.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        dbo_UrunStockEntities db = new dbo_UrunStockEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_urunler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewProduct()
        {
            List<SelectListItem> Deger = (from i in db.tbl_kategoriler.ToList()
                                          select new SelectListItem
                                          {
                                              Text = i.KATEGORIAD,
                                              Value = i.KATEGORIID.ToString()
                                          }).ToList();
            ViewBag.deger = Deger;
            return View();
        }

        [HttpPost]
        public ActionResult NewProduct(tbl_urunler p1)
        {
            db.tbl_urunler.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult DELETE(int id)
        {
            var urun = db.tbl_urunler.Find(id);
            db.tbl_urunler.Remove(urun);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}