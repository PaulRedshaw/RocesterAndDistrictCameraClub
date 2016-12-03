using Radcc.Data;
using Radcc.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Radcc.Mvc.Controllers
{
    public class UsefulLinksController : Controller
    {
        private IUsefulLinkRepository _usefulLinkRepository;
        public UsefulLinksController(IUsefulLinkRepository usefulLinkRepository)
        {
            this._usefulLinkRepository = usefulLinkRepository;
        }
        public UsefulLinksController()
        {

        }
        // GET: UsefulLinks
        public ActionResult _UsefulLinks()
        {
           var links = _usefulLinkRepository.GetAllLinks();
            if (links == null )
            {
                links = new List<UsefulLink>();
            }
            return View(links);
        }

 
    }
}
