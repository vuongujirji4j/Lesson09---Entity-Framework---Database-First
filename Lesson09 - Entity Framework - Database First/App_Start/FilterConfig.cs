using System.Web;
using System.Web.Mvc;

namespace Lesson09___Entity_Framework___Database_First
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
