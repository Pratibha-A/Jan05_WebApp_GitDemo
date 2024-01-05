using System.Web;
using System.Web.Mvc;

namespace Jan05_WebApp_GitDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
