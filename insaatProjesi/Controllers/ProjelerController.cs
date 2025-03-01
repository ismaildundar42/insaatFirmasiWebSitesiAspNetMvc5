using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;

namespace insaatProjesi.Controllers
{
    [AllowAnonymous]
    public class ProjelerController : Controller
    {
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();

        public ActionResult Index(string filter)
        {
            var degerler = db.tbl_projeler.AsQueryable();

            if (!string.IsNullOrEmpty(filter) && filter != "all")
            {
                degerler = degerler.Where(x => x.ProjeDurum == filter);
            }

            return View(degerler.ToList());
        }

        public ActionResult ProjeDetay(int id)
        {
            var deger = db.tbl_projeler.Where(x => x.ID == id).ToList();
            return View(deger);
        }


    }
}
