using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    public class AdminAnasayfaController : Controller
    {
        // GET: AdminAnasayfa
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var degerler = db.tbl_anasayfa.ToList();
            return View(degerler);
        }
        public ActionResult AnasayfaSil(int id)
        {
            var degerler = db.tbl_anasayfa.Find(id);
            db.tbl_anasayfa.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AnasayfaGetir(int id)
        {
            var degerler = db.tbl_anasayfa.Find(id);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult AnasayfaGetir(tbl_anasayfa p)
        {
            var ana = db.tbl_anasayfa.Find(p.ID);
            ana.SliderFoto1 = p.SliderFoto1;
            ana.SliderFoto2 = p.SliderFoto2;
            ana.SliderFoto3 = p.SliderFoto3;
            ana.Slider1Soz1 = p.Slider1Soz1;
            ana.Slider1Soz2 = p.Slider1Soz2;
            ana.Slider2Soz1 = p.Slider2Soz1;
            ana.Slider2Soz2 = p.Slider2Soz2;
            ana.Slider3Soz1 = p.Slider3Soz1;
            ana.Slider3Soz2 = p.Slider3Soz2;
            ana.Baslik1 = p.Baslik1;
            ana.Aciklama1 = p.Aciklama1;
            ana.Baslik2 = p.Baslik2;
            ana.Aciklama2 = p.Aciklama2;
            ana.Baslik3 = p.Baslik3;
            ana.Aciklama3 = p.Aciklama3;
            ana.VideoLink = p.VideoLink;
            ana.Yorumcu1Ad = p.Yorumcu1Ad;
            ana.Yorumcu1Meslek = p.Yorumcu1Meslek;
            ana.Yorumcu1Yorum = p.Yorumcu1Yorum;
            ana.Yorumcu2Ad = p.Yorumcu2Ad;
            ana.Yorumcu2Meslek = p.Yorumcu2Meslek;
            ana.Yorumcu2Yorum = p.Yorumcu2Yorum;
            ana.Yorumcu3Ad = p.Yorumcu3Ad;
            ana.Yorumcu3Meslek = p.Yorumcu3Meslek;
            ana.Yorumcu3Yorum = p.Yorumcu3Yorum;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AnasayfaEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AnasayfaEkle(tbl_anasayfa p)
        {
            db.tbl_anasayfa.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}