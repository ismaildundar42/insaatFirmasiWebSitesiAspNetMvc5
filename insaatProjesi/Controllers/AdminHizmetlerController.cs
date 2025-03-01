using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    public class AdminHizmetlerController : Controller
    {
        // GET: AdminHizmetler
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();

        [Authorize]
        public ActionResult Index()
        {
            var degerler = db.tbl_hizmetler.ToList();
            return View(degerler);
        }
        public ActionResult HizmetSil(int id)
        {
            var degerler = db.tbl_hizmetler.Find(id);
            db.tbl_hizmetler.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HizmetGetir(int id)
        {
            var degerler = db.tbl_hizmetler.Find(id);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult HizmetGetir(tbl_hizmetler p)
        {
            var hizmet = db.tbl_hizmetler.Find(p.ID);
            hizmet.Baslik = p.Baslik;
            hizmet.Aciklama = p.Aciklama;
            hizmet.Resim = p.Resim;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HizmetEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HizmetEkle(tbl_hizmetler p)
        {
            db.tbl_hizmetler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}