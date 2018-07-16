using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BasicASP.NETMvc.Models;

namespace BasicASP.NETMvc.Controllers
{
    [AllowAnonymous]
    public class RazorViewController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IfCondition()
        {
            return View();
        }

        public ActionResult SwitchCondition()
        {
            return View();
        }

        public ActionResult Loop()
        {
            var List=new List<Movie>()
            {
                new Movie(1,"When Harry Met Sally 1",new DateTime(),new decimal(6.99)),
                new Movie(2,"When Harry Met Sally 2",new DateTime(),new decimal(6.99)),
                new Movie(3,"When Harry Met Sally 3",new DateTime(),new decimal(6.99))
            };
            return View(List);
        }
    }
}