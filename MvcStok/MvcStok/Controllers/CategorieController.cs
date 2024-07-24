using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;

namespace MvcStok.Controllers
{
    public class CategorieController : Controller
    {
        // GET: Categorie
        dbo_UrunStockEntities db = new dbo_UrunStockEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_kategoriler.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult NewCategorie()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewCategorie(tbl_kategoriler p1)
        {
            db.tbl_kategoriler.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult DELETE (int id)
        {
            var kategori = db.tbl_kategoriler.Find(id);
            db.tbl_kategoriler.Remove(kategori);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult kategoriGetir(int id)
        {
            var kategori = db.tbl_kategoriler.Find(id);
            return View("kategoriGetir", kategori);
        }       
    }
}