using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class MembersController : AdminController
    {
        // GET: Admin/Members
        public ActionResult Index()
        {
            return View();
        }
    }
}