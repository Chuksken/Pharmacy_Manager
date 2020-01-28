using System.Web;
using System.Web.Mvc;

namespace Pharmacy_Manager.UI_API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
