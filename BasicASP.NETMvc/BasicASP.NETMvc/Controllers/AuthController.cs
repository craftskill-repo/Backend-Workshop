using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;
using BasicASP.NETMvc.Models;

namespace BasicASP.NETMvc.Controllers
{
    /*
     * LoginCheckFilter is BasicASP.NETMvc.filter.LoginFilter
     *
     *
     */
    public class AuthController : Controller
    {
        [System.Web.Mvc.AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [System.Web.Mvc.AllowAnonymous]
        [System.Web.Mvc.HttpPost]
        public ActionResult Login(User user)
        {
            if (user == null || !"admin".Equals(user.UserName) || !"admin".Equals(user.PassWord))
            {
                ViewBag.Error = "UserName and PassWord is admin";
                return View();
            }

            CreateAuthCookie(user.UserName);
            AddValusToSession(user.UserName);
            return RedirectToAction("Page");
        }


        //basic points 14 please make sure this action should be authed.
        [ValidateAntiForgeryToken]
        [System.Web.Http.Authorize]
        public ActionResult Page()
        {
            return View();
        }

        private void CreateAuthCookie(string userName)
        {
            //basic points 16 please add param into Cookie 
            // use cookie auth
        }

        private void AddValusToSession(string userName)
        {
            //basic points 17 Add param into Session and Seeeion key is "userName"
        }
    }
}