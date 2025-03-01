using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    [AllowAnonymous]
    public class IletisimController : Controller
    {
        // GET: Iletisim
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();
        public ActionResult Index()
        {
            var iletisim = db.tbl_iletisim.ToList();
            return View(iletisim);
        }
    }
}