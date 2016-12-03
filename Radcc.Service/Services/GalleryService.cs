using Radcc.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Radcc.Model.Models;
using Radcc.Data.Interfaces;

namespace Radcc.Service.Services
{
    public class GalleryService : IGalleryService
    {
        private readonly IGalleryRepository _galleryRepository;
        private IUnitOfWork _unitOfWork;
        public GalleryService(IGalleryRepository galleryRepository, IUnitOfWork unitOfWork)
        {
            this._galleryRepository = galleryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void CreateGalleryImage(Gallery galleryImage)
        {
            _galleryRepository.Add(galleryImage);
           
        
        }

        public void DeleteGalleyImage(Gallery image)
        {
            _galleryRepository.Delete(image);
          
        }

        public Gallery GetGalleryImageById(int id)
        {
            var galleryImage = _galleryRepository.GetById(id);
            return galleryImage;
        }

        public IEnumerable<Gallery> GetHomepageImages()
        {
            var gallery = _galleryRepository.GetHomepageImages();
            return gallery;
        }

        public void SaveImage()
        {
            _unitOfWork.Commit();
        }
    }
}
