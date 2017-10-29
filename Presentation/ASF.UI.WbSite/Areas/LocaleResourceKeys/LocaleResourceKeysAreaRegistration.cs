using System.Web.Mvc;

namespace ASF.UI.WbSite.Areas.LocaleResourceKeys
{
    public class LocaleResourceKeysAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LocaleResourceKeys";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LocaleResourceKeys_default",
                "LocaleResourceKeys/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}