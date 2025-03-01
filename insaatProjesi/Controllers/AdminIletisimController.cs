using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    public class AdminIletisimController : Controller
    {
        // GET: AdminIletisim
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var degerler = db.tbl_iletisim.ToList();
            return View(degerler);
        }
        public ActionResult IletisimSil(int id)
        {
            var deger = db.tbl_iletisim.Find(id);
            db.tbl_iletisim.Remove(deger);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult IletisimBilgileriGetir(int id)
        {
            var degerler = db.tbl_iletisim.Find(id);
            return View(degerler);
        }
        [HttpPost]
        public ActionResult IletisimBilgileriGetir(tbl_iletisim p)
        {
            var iletisim = db.tbl_iletisim.Find(p.ID);
            iletisim.Konum = p.Konum;
            iletisim.Telefon = p.Telefon;
            iletisim.Mail = p.Mail;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult IletisimBilgileriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult IletisimBilgileriEkle(tbl_iletisim p)
        {
            db.tbl_iletisim.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}