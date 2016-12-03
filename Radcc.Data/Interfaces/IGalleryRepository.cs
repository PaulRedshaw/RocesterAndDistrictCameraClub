using Radcc.Model;
using System.Collections.Generic;

namespace Radcc.Data
{
    public interface IGalleryRepository
    {
        void CreateGalleryImage(Gallery galleryImage);
        void DeleteGalleyImage(Gallery image);
        Gallery GetGalleryImageById(int id);
        IEnumerable<Gallery> GetHomepageImages();
    }
}