using Radcc.Data.Infrastructure;
using Radcc.Model;
using Radcc.Service;
using Radcc.Service.Interfaces;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class NewsArticlesController : Controller
    {
        private UnitOfWork unitOfWork;
        public NewsArticlesController(INewsArticleService newsArticleService)
        {
            this._newsArticleService = newsArticleService;
        }

        // GET: Admin/NewsArticles
        public ActionResult Index()
        {
            return View(_newsArticleService.GetAllNewsArticles());
        }

        // GET: Admin/NewsArticles/Details/5
        public ActionResult Details(int id)
        {
            NewsArticle newsArticle = _newsArticleService.GetNewsArticleById(id);
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
                _newsArticleService.CreateNewsArticle(newsArticle);
           
                return RedirectToAction("Index");
            }

            return View(newsArticle);
        }

        // GET: Admin/NewsArticles/Edit/5
        public ActionResult Edit(int id)
        {
            NewsArticle newsArticle = _newsArticleService.GetNewsArticleById(id);
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
                _newsArticleService.UpdateNewsArticle(newsArticle);
            
                return RedirectToAction("Index");
            }
            return View(newsArticle);
        }

        // GET: Admin/NewsArticles/Delete/5
        public ActionResult Delete(int id)
        {
       
            NewsArticle newsArticle = _newsArticleService.GetNewsArticleById(id);
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
            NewsArticle newsArticle = _newsArticleService.GetNewsArticleById(id);
            _newsArticleService.DeleteNewsArticle(newsArticle);
         
            return RedirectToAction("Index");
        }

      
    }
}
