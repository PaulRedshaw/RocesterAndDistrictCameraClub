using Radcc.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radcc.Service.Interfaces
{
   public interface IGalleryService
    {
        IEnumerable<Gallery> GetHomepageImages();
        void CreateGalleryImage(Gallery image);
        void DeleteGalleyImage(Gallery image);
        Gallery GetGalleryImageById(int id);
        void SaveImage();
    }
}
