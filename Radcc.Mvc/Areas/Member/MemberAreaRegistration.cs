using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Member
{
    public class MemberAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Member";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Member_default",
                "Member/{controller}/{action}/{id}",
                new {area="Member", controller = "Home", action = "Index", id = UrlParameter.Optional },
                new string [] { "Radcc.Mvc.Areas.Member.Controllers" }
            );
        }
    }
}