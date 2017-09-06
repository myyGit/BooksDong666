using QX_Frame.Web.Filter;
using System.Web.Mvc;

namespace QX_Frame.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new App.Web.Filters.ExceptionAttribute_DG());
            filters.Add(new ExceptionAttribute());
        }
    }
}