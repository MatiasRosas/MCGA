using System.Web.Mvc;

namespace ASF.UI.WbSite.Areas.LocaleStringResorces
{
    public class LocaleStringResorcesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "LocaleStringResorces";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "LocaleStringResorces_default",
                "LocaleStringResorces/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}