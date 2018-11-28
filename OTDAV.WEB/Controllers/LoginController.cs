using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using OTDAV.DOMAIN.Entities;
using OTDAV.SERVICE.SERVICE;

namespace OTDAV.WEB.Controllers
{
    public class LoginController : Controller
    {
        LoginRegisterService LRS = new LoginRegisterService();
        // GET: Login


        /* [HttpGet]
         public ActionResult Login()
         {
             return View("Login");
         }
         [HttpPost]
         public ActionResult Login(adherent adherent)
         {
             return RedirectToRoute(LRS.doLogin(adherent) != null ? "Archive/Index" : "Home/Index");
         }
         */

        public async Task<ActionResult> Login()
        {
            var currentUser = (adherent)System.Web.HttpContext.Current.Session["IUser"];
            if (currentUser != null)
            {
                return RedirectToAction("Index","Home");
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(adherent adherent)
        {

            adherent currentUser =  LRS.doLogin(adherent);
            //user currentUser = null;
            if (currentUser != null)
            {
                System.Web.HttpContext.Current.Session.Add("IUser", currentUser);
                return RedirectToAction("Index","Home");
            }
            ModelState.AddModelError("", "Email/Username/Password is/are incorrect");
            return View(adherent);
        }
    }
}