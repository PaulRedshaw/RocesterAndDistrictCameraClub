using System.Collections.Generic;
using Radcc.Model;

namespace Radcc.Data
{
    public interface INewsArticleRepository
    {
        void Add(NewsArticle newsArticle);
        void Delete(NewsArticle newsArticle);
        IEnumerable<NewsArticle> GetAllNewsArticles();
        NewsArticle GetNewsArticleById(int Id);
        void Update(NewsArticle entity);
    }
}