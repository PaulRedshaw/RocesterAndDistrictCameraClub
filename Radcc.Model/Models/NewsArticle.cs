using System;

namespace Radcc.Model
{
    public class NewsArticle
    {
        public int Id { get; set; }
        public string ArticleHeading { get; set; }
        public string article { get; set; }
        public DateTime DatePosted { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }


    }
}
