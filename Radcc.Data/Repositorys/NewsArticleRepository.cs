using Radcc.Data.Context;
using Radcc.Data.Infrastructure;
using Radcc.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Radcc.Data
{
    public class NewsArticleRepository : INewsArticleRepository
    {
        private readonly ApplicationDbContext _context;
        public NewsArticleRepository(ApplicationDbContext context)
        {
            this._context = context;
        }
        public IEnumerable<NewsArticle> GetAllNewsArticles()
        {
            return _context.NewsArticles.ToList();
        }

        public NewsArticle GetNewsArticleById(int Id)
        {
            return _context.NewsArticles.Find(Id);

        }
       
        public void Add(NewsArticle newsArticle)
        {
            this._context.NewsArticles.Add(newsArticle);
        
        }
        public void Update(NewsArticle entity)
        {
            throw new NotImplementedException();
        }
        public void Delete(NewsArticle newsArticle)
        {
            this._context.NewsArticles.Remove(newsArticle);
   
        }

        

       
        
        

       
       

       

       
    }
}
