using System.Linq;
using System.Web.Mvc;
using insaatProjesi.Models.Entitiy;
namespace insaatProjesi.Controllers
{
    [AllowAnonymous]
    public class HakkimizdaController : Controller
    {
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();

        public ActionResult Index()
        {
            var degerler = db.tbl_hakkimizda.ToList();
            return View(degerler);
        }
    }
}
