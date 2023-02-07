using System.Web;
using System.Web.Mvc;

namespace Emptyproj_Controller_Concept
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
