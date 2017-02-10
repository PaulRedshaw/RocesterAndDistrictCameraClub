using Radcc.Data.Context;
using System.Linq;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class RoleController : AdminController
    {
        private ApplicationDbContext _context;
        public RoleController()
        {
            this._context = new ApplicationDbContext();
        }
        // GET: Admin/Role

        public ActionResult Index()
        {

            //if (User.Identity.IsAuthenticated)
            //{


            //    if (!isAdminUser())
            //    {
            //        return RedirectToAction("Index", "Home");
            //    }
            //}
            //else
            //{
            //    return RedirectToAction("Index", "Home");
            //}

            var Roles = _context.Roles.ToList();
            return View(Roles);

        }

        //public Boolean isAdminUser()
        //{
        //    if (User.Identity.IsAuthenticated)
        //    {
        //        var user = User.Identity;
        //        ApplicationDbContext context = new ApplicationDbContext();
        //        var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
        //        var s = UserManager.GetRoles(user.GetUserId());
        //        if (s[0].ToString() == "Admin")
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    return false;
        //}


    }
}