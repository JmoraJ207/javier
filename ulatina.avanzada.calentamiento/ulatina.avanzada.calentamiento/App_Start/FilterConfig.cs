using System.Web;
using System.Web.Mvc;

namespace ulatina.avanzada.calentamiento
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
