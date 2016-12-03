using System.Web.Mvc;

namespace Radcc.Mvc.Admin.Controllers
{
    public class MembersController : Controller
    {
        // GET: Admin/Members
        public ActionResult Index()
        {
            return View();
        }
    }
}