using System.Web;
using System.Web.Mvc;

namespace Gama.TesteASPNETMVC.WEB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
