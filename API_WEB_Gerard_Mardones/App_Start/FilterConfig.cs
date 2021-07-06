using System.Web;
using System.Web.Mvc;

namespace API_WEB_Gerard_Mardones
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
