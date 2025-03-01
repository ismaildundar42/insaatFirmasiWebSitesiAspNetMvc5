using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    public class AdminHakkimizdaController : Controller
    {
        // GET: AdminHakkimizda
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var degerler = db.tbl_hakkimizda.ToList();
            return View(degerler);
        }
        public ActionResult HakkimizdaSil(int id)
        {
            var degerler = db.tbl_hakkimizda.Find(id);
            db.tbl_hakkimizda.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HakkimizdaGetir(int id)
        {
            var degerler = db.tbl_hakkimizda.Find(id);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult HakkimizdaGetir(tbl_hakkimizda p)
        {
            var degerler = db.tbl_hakkimizda.Find(p.ID);
            degerler.Baslik = p.Baslik;
            degerler.Aciklama = p.Aciklama;
            degerler.CalisanSayisi = p.CalisanSayisi;
            degerler.MusteriMemnuniyeti = p.MusteriMemnuniyeti;
            degerler.TamamlanmisProjeler = p.TamamlanmisProjeler;
            degerler.DevamEdenProjeler = p.DevamEdenProjeler;
            degerler.Soru1 = p.Soru1;
            degerler.Cevap1 = p.Cevap1;
            degerler.Soru2 = p.Soru2;
            degerler.Cevap2 = p.Cevap2;
            degerler.Soru3 = p.Soru3;
            degerler.Cevap3 = p.Cevap3;
            degerler.Soru4 = p.Soru4;
            degerler.Cevap4 = p.Cevap4;
            degerler.Soru5 = p.Soru5;
            degerler.Cevap5 = p.Cevap5;
            degerler.Soru6 = p.Soru6;
            degerler.Cevap6 = p.Cevap6;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult HakkimizdaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult HakkimizdaEkle(tbl_hakkimizda p)
        {
            db.tbl_hakkimizda.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}