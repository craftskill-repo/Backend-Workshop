
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
            // change "null" to correct value.
            return null;
        }

        public ActionResult Baidu()
        {
            // change "" to Redirect to www.baidu.com
            var result = new RedirectResult("http://www.baidu.com");
            return null;
        }

        public ActionResult Page()
        {
            // change "" to correct value.
            string str = "";
            return Content(str);
        }

        public ActionResult EmptyAction()
        {
            // change "null" to correct value.
            return null;
        }

        public ActionResult Redirect2Action()
        {
            // change null : Redirect to Baidu Action
            return null;
        }

        public ActionResult Redirect2Route()
        {
            // change null : Redirect to Page Route
            return null;
        }

        public ActionResult JsonResult()
        {
            var result = new JsonObject("ActionResultController", "JsonResult");
            //change null to return a json obj
            return Json(null);
        }

        public ActionResult ScriptResult()
        {
            var returnData=new JavaScriptResult();
            var result = "<script><alert>hi,welcome to .net</alert></script>";
            returnData.Script = result;
            //change null to return a script code
            return null;
        }

        public ActionResult HttpUnauthorizedResult()
        {
            // change "null" to correct value.
            return null;
        }

        public ActionResult HttpNotFoundResult()
        {
            // change "null" to correct value.
            return null;
        }

        public ActionResult HttpStatusCodeResult()
        {
            // change "null" to correct value.
            return null;
        }

    }
}