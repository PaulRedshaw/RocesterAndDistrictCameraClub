using Radcc.Data;
using Radcc.Data.Interfaces;
using Radcc.Model;
using Radcc.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Radcc.Service.Services
{
    public class NewsArticleService : INewsArticleService
    {
        private readonly INewsArticleRepository _newsArticleRepository;
        private readonly IUnitOfWork _unitOfWork;

        public NewsArticleService(INewsArticleRepository newsRepository, IUnitOfWork unitOfWork)
        {
            this._newsArticleRepository = newsRepository;
            this._unitOfWork = unitOfWork;
        }
        public void CreateNewsArticle(NewsArticle newsArticle)
        {
            this._newsArticleRepository.Add(newsArticle);
            this.SaveChanges();

        }

        public void DeleteNewsArticle(NewsArticle newsArticle)
        {
            this._newsArticleRepository.Delete(newsArticle);
            this.SaveChanges();
        }

        public IEnumerable<NewsArticle> GetAllNewsArticles()
        {
            return _newsArticleRepository.GetAll();
        }

        public NewsArticle GetNewsArticleById(int Id)
        {
            return _newsArticleRepository.GetById(Id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void UpdateNewsArticle(NewsArticle newsArticle)
        {
            this.SaveChanges();
        }
    }
}
