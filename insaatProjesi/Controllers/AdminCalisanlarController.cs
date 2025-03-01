using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    public class AdminCalisanlarController : Controller
    {
        // GET: AdminCalisanlar
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();

       // [Authorize]
        public ActionResult Index()
        {
            var degerler = db.tbl_calisanlar.ToList();
            return View(degerler);
        }
        public ActionResult CalisanSil(int id)
        {
            var degerler = db.tbl_calisanlar.Find(id);
            db.tbl_calisanlar.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CalisanGetir(int id)
        {
            var calisanlar = db.tbl_calisanlar.Find(id);
            return View(calisanlar);
        }
        [HttpPost]
        public ActionResult CalisanGetir(tbl_calisanlar c)
        {
            var calisanlar = db.tbl_calisanlar.Find(c.ID);
            calisanlar.AdSoyad = c.AdSoyad;
            calisanlar.Gorev = c.Gorev;
            calisanlar.ResimUrl = c.ResimUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CalisanEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalisanEkle(tbl_calisanlar c)
        {
            db.tbl_calisanlar.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}