using System.Web;
using System.Web.Mvc;

namespace HTTP5101Assignment1_UditeshJha
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
