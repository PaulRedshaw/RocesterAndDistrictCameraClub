using Radcc.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Service.Interfaces
{
    public interface INewsArticleService
    {
        IEnumerable<NewsArticle> GetAllNewsArticles();
        NewsArticle GetNewsArticleById(int Id);
        void CreateNewsArticle(NewsArticle newsArticle);
        void UpdateNewsArticle(NewsArticle newsArticle);
        void DeleteNewsArticle(NewsArticle newsArticle);
        void SaveChanges();

    }
}
