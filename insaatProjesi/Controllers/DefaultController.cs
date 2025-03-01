using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        // GET: Default
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var degerler = db.tbl_anasayfa.ToList();
            return View(degerler);
        }
    }
}