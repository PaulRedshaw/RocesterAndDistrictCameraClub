using Radcc.Data.Persistence;
using Radcc.Model;
using Radcc.Mvc.CustomClasses;
using System;
using System.Web.Mvc;

namespace Radcc.Mvc.Controllers
{
    public class ProgrammesController : Controller
    {

        private IUnitOfWork _unitOfWork;

        public int PageSize = 4;
        //
        // GET: /Programme/
        public ProgrammesController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;

        }
        public ActionResult CurrentProgramme()
        {
            var programmeDateFilter = new ProgrammeFilterDates();

            var startDate = GetStartDate();
            var endDate = GetEndDate();
            var programme = _unitOfWork.Programmes.CurrentYearsProgramme(startDate, endDate);

            if (programme != null)
            {
                //TODO: HeadingTitle = Programme StartOfSeasonYear - EndOfSeasonYear Season.
                ViewBag.Title = "Programme " + startDate.Year + " - " + endDate.Year + " Season";
            }
            else
            {
                ViewBag.Title = "The current years programme has not yet been set!";
            }
            return View(programme);
        }

        public ActionResult _NextMeeting()
        {
            Programme nextMeeting = _unitOfWork.Programmes.GetNextProgrammeEvent();

            return View(nextMeeting);

        }

        public DateTime GetStartDate()
        {
            var startDate = new DateTime();
            if (DateTime.Today.Month >= 1 && DateTime.Today.Month <= 5)
            {
                startDate = new DateTime(DateTime.Today.Year - 1, 06, 01);
            }
            else
            {
                startDate = new DateTime(DateTime.Today.Year, 06, 01);
            }

            return startDate;
        }
        public DateTime GetEndDate()
        {
            var endDate = new DateTime();
            if (DateTime.Today.Month >= 1 && DateTime.Today.Month <= 5)
            {
                endDate = new DateTime(DateTime.Today.Year, 05, 31);
            }
            else
            {
                endDate = new DateTime(DateTime.Today.Year + 1, 05, 31);
            }
            return endDate;
        }

    }
}