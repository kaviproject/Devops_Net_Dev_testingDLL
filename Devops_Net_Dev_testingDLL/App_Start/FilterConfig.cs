using System.Web;
using System.Web.Mvc;

namespace Devops_Net_Dev_testingDLL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
