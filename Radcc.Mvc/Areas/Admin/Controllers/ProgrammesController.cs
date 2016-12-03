using Radcc.Model;
using Radcc.Service;
using Radcc.Service.Interfaces;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class ProgrammesController : Controller
    {
        
        private IProgrammeService _programmeService;
   
        public ProgrammesController(IProgrammeService programmeService)
        {
            this._programmeService = programmeService;
        }
        // GET: Admin/Events
        public ActionResult Index()
        {
           var events = _programmeService.GetAllProgrammeEvents();
            return View(events);
        }

        // GET: Admin/Events/Details/5
        public ActionResult Details(int id)
        {
            Programme meeting = _programmeService.GetProgrammeById(id);
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
                _programmeService.AddProgramme(programme);
                return RedirectToAction("Index");
            }

            
            return View(programme);
        }

        // GET: Admin/Events/Edit/5
        public ActionResult Edit(int id)
        {
        
            Programme meeting = _programmeService.GetProgrammeById(id);

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
                _programmeService.UpdateProgramme(programme);
                return RedirectToAction("Index");
            }
        
            return View(programme);
        }

        // GET: Admin/Events/Delete/5
        public ActionResult Delete(int id)
        {

           var meeting = _programmeService.GetProgrammeById(id);

            return View(meeting);
        }

        // POST: Admin/Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var meeting = _programmeService.GetProgrammeById(id);
            _programmeService.DeleteProgramme(meeting);
            return RedirectToAction("Index");
        }

       
    }
}
