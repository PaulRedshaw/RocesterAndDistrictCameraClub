using Radcc.Data.Infrastructure;
using Radcc.Data.Interfaces;
using Radcc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Data
{
    public class GalleryRepository : RepositoryBase<Gallery>, IGalleryRepository
    {
        public GalleryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Gallery> GetHomepageImages()
        {
            var imageList = this.DbContext.Galleries.ToList();
            return imageList;
           
        }
    }
}
