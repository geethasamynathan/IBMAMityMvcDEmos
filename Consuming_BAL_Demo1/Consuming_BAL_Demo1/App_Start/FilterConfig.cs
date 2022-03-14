using System.Web;
using System.Web.Mvc;

namespace Consuming_BAL_Demo1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
