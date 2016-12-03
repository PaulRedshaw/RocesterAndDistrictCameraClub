using Radcc.Model;
using Radcc.Service;
using Radcc.Service.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class UsefulLinksController : Controller
    {
        private IUsefulLinkService _usefulLinkService;
        public UsefulLinksController (IUsefulLinkService usefulLinkService)
	{
            this._usefulLinkService = usefulLinkService;
	}
        
        // GET: Admin/UsefulLinks
        public ActionResult UsefulLinkList()
        {       
            IEnumerable<UsefulLink> usefulLinks = _usefulLinkService.GetAllLinks();
          
            return View(usefulLinks);
        }

        // GET: Admin/UsefulLinks/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/UsefulLinks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/UsefulLinks/Create
        [HttpPost]
        public ActionResult Create(UsefulLink link)
        {
          
            try
            {
                _usefulLinkService.CreateUsefulLink(link);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/UsefulLinks/Edit/5
        public ActionResult Edit(int id)
        {
          
            UsefulLink link = _usefulLinkService.GetUsefulLinkById(id);
            if (link == null)
            {
                return HttpNotFound();
            }
          
            return View(link);
        }

        // POST: Admin/UsefulLinks/Edit/5
        [HttpPost]
        public ActionResult Edit([Bind(Include = "LinkId,Name,Description,URL")] UsefulLink link)
        {
            if (ModelState.IsValid)
            {
               _usefulLinkService.UpdateUsefulLink(link);
              return RedirectToAction("Index");
            }
           
            return View(link);
        }

        // GET: Admin/UsefulLinks/Delete/5
        public ActionResult Delete(int id)
        {
           
            UsefulLink link = _usefulLinkService.GetUsefulLinkById(id);
            if (link == null)
            {
                return HttpNotFound();
            }
            return View(link);
        }

        // POST: Admin/UsefulLinks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UsefulLink link = _usefulLinkService.GetUsefulLinkById(id);
            _usefulLinkService.DeleteUsefulLink(link);
            return RedirectToAction("Index");
        }

        
    }
}
