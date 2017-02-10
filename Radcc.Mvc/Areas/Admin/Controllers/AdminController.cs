using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    /// <summary>
    /// Base controller for all Admin area
    /// </summary>
    [Authorize(Roles = "Admin")]
    public abstract class AdminController : Controller
    {

    }
}