using System.Web;
using System.Web.Mvc;

namespace m13010203.MvcMusicStore
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
