using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;


namespace MvcStok.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        dbo_UrunStockEntities db = new dbo_UrunStockEntities();
        public ActionResult Index()
        {
            var degerler = db.tbl_musteriler.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult NewCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewCustomer(tbl_musteriler p1)
        {
            db.tbl_musteriler.Add(p1);
            db.SaveChanges();
            return View();
        }

        public ActionResult DELETE (int id)
        {
            var musteri = db.tbl_musteriler.Find(id);
            db.tbl_musteriler.Remove(musteri);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}