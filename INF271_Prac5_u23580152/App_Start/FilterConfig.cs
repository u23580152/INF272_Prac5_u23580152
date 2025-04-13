using System.Web;
using System.Web.Mvc;

namespace INF271_Prac5_u23580152
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
