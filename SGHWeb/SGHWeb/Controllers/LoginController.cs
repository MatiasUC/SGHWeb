using SGHWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SGHWeb.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginSGHModel model, string returnUrl)
        {
            if (ModelState.IsValid && (model.username.Equals("mtoro") && model.password.Equals("deicide")))
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Las credenciales suministradas no son válidas.");
            return View(model);
        }

    }
}
