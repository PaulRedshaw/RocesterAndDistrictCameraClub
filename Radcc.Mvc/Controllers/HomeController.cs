using Radcc.Data.Persistence;
using Radcc.Mvc.ViewModels;
using System.Web.Mvc;

namespace Radcc.Mvc.Controllers
{
    public class HomeController : Controller
    {


        private IUnitOfWork _unitOfWork;


        public HomeController(IUnitOfWork unitOfWork)
        {

            this._unitOfWork = unitOfWork;

        }

        public ActionResult Index()
        {
            var viewModel = new HomeViewModel();
            viewModel.UsefulLinks = _unitOfWork.UsefulLinks.GetAllLinks();
            viewModel.NewsArticles = _unitOfWork.NewsArticles.GetAllNewsArticles();
            viewModel.NextMeeting = _unitOfWork.Programmes.GetNextProgrammeEvent();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}
