using System.Web;
using System.Web.Mvc;

namespace PhamTuanPhong_kiemtraFe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
