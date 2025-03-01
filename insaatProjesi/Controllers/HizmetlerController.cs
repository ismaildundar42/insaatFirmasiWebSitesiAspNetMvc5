using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    [AllowAnonymous]
    public class HizmetlerController : Controller
    {
        // GET: Hizmetler
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var degerler = db.tbl_hizmetler.ToList();
            return View(degerler);
        }
        public ActionResult hizmetDetay(int id)
        {
            var degerler = db.tbl_hizmetler.Where(x => x.ID == id).ToList();
            return View(degerler);
        }
    }
}