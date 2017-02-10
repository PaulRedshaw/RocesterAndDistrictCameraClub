using Radcc.Data.Persistence;
using Radcc.Model;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class ProgrammesController : AdminController
    {

        private readonly IUnitOfWork _unitOfWork;

        public ProgrammesController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        // GET: Admin/Events
        public ActionResult Index()
        {
            var events = _unitOfWork.Programmes.GetAllProgrammeEvents();
            return View(events);
        }

        // GET: Admin/Events/Details/5
        public ActionResult Details(int id)
        {
            Programme meeting = _unitOfWork.Programmes.GetProgrammeById(id);
            return View(meeting);
        }

        // GET: Admin/Events/Create
        public ActionResult Create()
        {
            var programme = new Programme();

            return View(programme);
        }

        // POST: Admin/Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Title,Description,Comment")] Programme programme)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Programmes.Add(programme);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }


            return View(programme);
        }

        // GET: Admin/Events/Edit/5
        public ActionResult Edit(int id)
        {

            Programme meeting = _unitOfWork.Programmes.GetProgrammeById(id);

            return View(meeting);
        }

        // POST: Admin/Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Date,Title,Description,Comment")] Programme programme)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Programmes.Update(programme);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(programme);
        }

        // GET: Admin/Events/Delete/5
        public ActionResult Delete(int id)
        {

            var meeting = _unitOfWork.Programmes.GetProgrammeById(id);

            return View(meeting);
        }

        // POST: Admin/Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var meeting = _unitOfWork.Programmes.GetProgrammeById(id);
            _unitOfWork.Programmes.Delete(meeting);
            _unitOfWork.Commit();
            return RedirectToAction("Index");
        }


    }
}
