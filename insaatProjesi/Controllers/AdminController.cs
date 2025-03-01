using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var admin = db.tbl_admin.ToList();
            return View(admin);
        }
        public ActionResult AdminSil(int id)
        {
            var deger = db.tbl_admin.Find(id);
            db.tbl_admin.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminGetir(int id)
        {
            var admin = db.tbl_admin.Find(id);
            return View(admin);
        }
        [HttpPost]
        public ActionResult AdminGetir(tbl_admin p)
        {
            var admin = db.tbl_admin.Find(p.ID);
            admin.KullaniciAdi = p.KullaniciAdi;
            admin.Sifre = p.Sifre;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AdminEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminEkle(tbl_admin p)
        {
            db.tbl_admin.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}