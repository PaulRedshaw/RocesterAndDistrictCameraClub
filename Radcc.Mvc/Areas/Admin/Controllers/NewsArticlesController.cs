using Radcc.Data.Persistence;
using Radcc.Model;
using System.Web.Mvc;

namespace Radcc.Mvc.Admin.Controllers
{
    public class NewsArticlesController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public NewsArticlesController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        // GET: Admin/NewsArticles
        public ActionResult Index()
        {
            return View(_unitOfWork.NewsArticles.GetAllNewsArticles());
        }

        // GET: Admin/NewsArticles/Details/5
        public ActionResult Details(int id)
        {
            NewsArticle newsArticle = _unitOfWork.NewsArticles.GetNewsArticleById(id);
            if (newsArticle == null)
            {
                return HttpNotFound();
            }
            return View(newsArticle);
        }

        // GET: Admin/NewsArticles/Create
        public ActionResult Create()
        {
            ViewBag.Title = "Create a News Article";
            return View();
        }

        // POST: Admin/NewsArticles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,HeadLine,Article,image")] NewsArticle newsArticle)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.NewsArticles.Add(newsArticle);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(newsArticle);
        }

        // GET: Admin/NewsArticles/Edit/5
        public ActionResult Edit(int id)
        {
            NewsArticle newsArticle = _unitOfWork.NewsArticles.GetNewsArticleById(id);
            if (newsArticle == null)
            {
                return HttpNotFound();
            }
            return View(newsArticle);
        }

        // POST: Admin/NewsArticles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,HeadLine,Article,image")] NewsArticle newsArticle)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.NewsArticles.Update(newsArticle);
                _unitOfWork.Commit();
                return RedirectToAction("Index");
            }
            return View(newsArticle);
        }

        // GET: Admin/NewsArticles/Delete/5
        public ActionResult Delete(int id)
        {

            NewsArticle newsArticle = _unitOfWork.NewsArticles.GetNewsArticleById(id);
            if (newsArticle == null)
            {
                return HttpNotFound();
            }
            return View(newsArticle);
        }

        // POST: Admin/NewsArticles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NewsArticle newsArticle = _unitOfWork.NewsArticles.GetNewsArticleById(id);
            _unitOfWork.NewsArticles.Delete(newsArticle);
            _unitOfWork.Commit();

            return RedirectToAction("Index");
        }


    }
}
