using Radcc.Data.Persistence;
using Radcc.Model;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class UsefulLinksController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public UsefulLinksController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        // GET: Admin/UsefulLinks
        public ActionResult List()
        {
            IEnumerable<UsefulLink> usefulLinks = _unitOfWork.UsefulLinks.GetAllLinks();

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
            var link = new UsefulLink();
            return View(link);
        }

        // POST: Admin/UsefulLinks/Create
        [HttpPost]
        public ActionResult Create(UsefulLink link)
        {

            try
            {
                _unitOfWork.UsefulLinks.Add(link);
                _unitOfWork.Commit();

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

            UsefulLink link = _unitOfWork.UsefulLinks.GetById(id);
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
                _unitOfWork.UsefulLinks.Update(link);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(link);
        }

        // GET: Admin/UsefulLinks/Delete/5
        public ActionResult Delete(int id)
        {

            UsefulLink link = _unitOfWork.UsefulLinks.GetById(id);
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
            UsefulLink link = _unitOfWork.UsefulLinks.GetById(id);
            _unitOfWork.UsefulLinks.Delete(link);
            _unitOfWork.Commit();
            return RedirectToAction("Index");
        }


    }
}
