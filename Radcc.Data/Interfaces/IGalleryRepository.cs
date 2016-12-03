using Radcc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Data.Interfaces
{
    public interface IGalleryRepository : IRepository<Gallery>
    {
        IEnumerable<Gallery> GetHomepageImages();

    }
}
