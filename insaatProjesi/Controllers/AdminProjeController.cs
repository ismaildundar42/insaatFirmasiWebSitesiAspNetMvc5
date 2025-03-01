using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    public class AdminProjeController : Controller
    {
        // GET: AdminProje
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var degerler = db.tbl_projeler.ToList();
            return View(degerler);
        }
        public ActionResult ProjeSil(int id)
        {
            var proje = db.tbl_projeler.Find(id);
            db.tbl_projeler.Remove(proje);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ProjeGetir(int id)
        {
            var degerler = db.tbl_projeler.Find(id);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult ProjeGetir(tbl_projeler p)
        {
            var projeler = db.tbl_projeler.Find(p.ID);
            projeler.ProjeAdı = p.ProjeAdı;
            projeler.ProjeAciklama = p.ProjeAciklama;
            projeler.ProjeDurum = p.ProjeDurum;
            projeler.projeResim = p.projeResim;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult ProjeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ProjeEkle(tbl_projeler p)
        {
            db.tbl_projeler.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}