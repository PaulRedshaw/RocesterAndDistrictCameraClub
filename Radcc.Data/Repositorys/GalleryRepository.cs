using Radcc.Data.Context;
using Radcc.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Radcc.Data
{
    public class GalleryRepository : IGalleryRepository
    {
        private ApplicationDbContext _context;
        public GalleryRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void CreateGalleryImage(Gallery galleryImage)
        {
            _context.Gallerys.Add(galleryImage);


        }

        public void DeleteGalleyImage(Gallery image)
        {
            _context.Gallerys.Remove(image);

        }

        public Gallery GetGalleryImageById(int id)
        {
            var galleryImage = _context.Gallerys.Find(id);
            return galleryImage;
        }

        public IEnumerable<Gallery> GetHomepageImages()
        {
            var gallerys = _context.Gallerys.ToList();
            return gallerys;
        }
    }
}
