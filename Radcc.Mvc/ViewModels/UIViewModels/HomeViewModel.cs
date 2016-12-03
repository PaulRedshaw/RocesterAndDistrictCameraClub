using Radcc.Model;
using System.Collections.Generic;

namespace Radcc.Mvc.ViewModels
{
    public class HomeViewModel
    {
      
        public Programme NextMeeting { get; set; }
        public IEnumerable<NewsArticle> NewsArticles { get; set; }
        public IEnumerable<UsefulLink> UsefulLinks { get; set; }

        public HomeViewModel()
        {
            this.NextMeeting = new Programme();
            this.NewsArticles = new List<NewsArticle>();
            this.UsefulLinks = new List<UsefulLink>();
        }
    }
}