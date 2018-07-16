
using System.Web.Mvc;

namespace BasicASP.NETMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //please add authorcation filter
            
        }
    }
}
