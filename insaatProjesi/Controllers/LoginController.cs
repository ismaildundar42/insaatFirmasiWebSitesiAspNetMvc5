using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using insaatProjesi.Models.Entitiy;

namespace insaatProjesi.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        dbInsaatProjesiEntities2 db = new dbInsaatProjesiEntities2();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(tbl_admin p)
        {
            var loginBilgi = db.tbl_admin.FirstOrDefault(x => x.KullaniciAdi == p.KullaniciAdi && x.Sifre == p.Sifre);

            if (loginBilgi != null)
            {
                FormsAuthentication.SetAuthCookie(loginBilgi.KullaniciAdi, false);
                Session["KullaniciAdi"] = loginBilgi.KullaniciAdi.ToString();
                return RedirectToAction("Index", "AdminAnasayfa");
            }
            else
            {
                TempData["HataMesaji"] = "Kullanıcı adı veya şifre hatalı!";
                return RedirectToAction("Index");
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
