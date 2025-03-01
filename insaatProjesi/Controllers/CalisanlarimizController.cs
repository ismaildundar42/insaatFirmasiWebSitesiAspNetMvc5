using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    [AllowAnonymous]
    public class CalisanlarimizController : Controller
    {
        // GET: Calisanlarimiz
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var calisanlar = db.tbl_calisanlar.ToList();
            return View(calisanlar);
        }
    }
}