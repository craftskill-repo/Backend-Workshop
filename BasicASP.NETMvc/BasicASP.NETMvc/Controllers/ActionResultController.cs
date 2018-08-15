
using System.Web.Mvc;

using BasicASP.NETMvc.Models;

namespace BasicASP.NETMvc.Controllers
{
    [AllowAnonymous]
    public class ActionResultController : Controller
    {
        // GET: ActionResult
        public ActionResult Index()
        {
            //basic points 1 change "null" to correct value.
            return null;
        }

        public ActionResult Baidu()
        {
            //basic points 2 change "" to Redirect to www.baidu.com
            var result = new RedirectResult("http://www.baidu.com");
            return null;
        }

        public ActionResult Page()
        {
            //basic points 3 change "" to correct value.
            string str = "";
            return Content(str);
        }

        public ActionResult EmptyAction()
        {
            //basic points 4 change "null" to correct value.
            return null;
        }

        public ActionResult Redirect2Action()
        {
            //basic points 5 change null : Redirect to Baidu Action
            return null;
        }

        public ActionResult Redirect2Route()
        {
            //basic points 6 change null : Redirect to Page Route
            return null;
        }

        public ActionResult JsonResult()
        {
            var result = new JsonObject("ActionResultController", "JsonResult");
            //basic points 7  change null to return a json obj
            return Json(null);
        }

        public ActionResult ScriptResult()
        {
            var returnData=new JavaScriptResult();
            var result = "<script><alert>hi,welcome to .net</alert></script>";
            returnData.Script = result;
            //basic points 8 change null to return a script code
            return null;
        }

        public ActionResult HttpUnauthorizedResult()
        {
            //basic points 9 change "null" to correct value.
            return null;
        }

        public ActionResult HttpNotFoundResult()
        {
            //basic points 10 change "null" to correct value.
            return null;
        }

        public ActionResult HttpStatusCodeResult()
        {
            //basic points 11 change "null" to correct value.
            return null;
        }

    }
}