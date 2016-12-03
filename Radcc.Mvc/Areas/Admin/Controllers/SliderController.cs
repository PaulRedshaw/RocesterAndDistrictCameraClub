using Radcc.Model.Models;
using Radcc.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Radcc.Mvc.Areas.Admin.Controllers
{
    public class SliderController : Controller
    {
        private readonly IGalleryService _galleryService;
        public SliderController(IGalleryService galleryService)
        {
            this._galleryService = galleryService;

        }

        // GET: Gallery
        public ActionResult Index()
        {

            return View(this._galleryService.GetHomepageImages());
        }
        public ActionResult AddImage()
        {
            return View();

        }
        [HttpPost]
        public ActionResult AddImage(HttpPostedFileBase imagePath)
        {
            if (imagePath != null)
            {
                // this is for images of a sepecific resolution
                System.Drawing.Image img = System.Drawing.Image.FromStream(imagePath.InputStream);
                if ((img.Width != 800) && (img.Height != 600))
                {
                    ModelState.AddModelError("", "Image size must be 800 x 600 pixels");
                    return View();
                }
                //Upload pic
                string pic = System.IO.Path.GetFileName(imagePath.FileName);
                string path = System.IO.Path.Combine(Server.MapPath("~/Images/SiteImages/HomepageSlider"), pic);
                imagePath.SaveAs(path);
                Gallery gallery = new Gallery { ImagePath = "~/Images/SiteImages/HomepageSlider/" + pic };


                _galleryService.CreateGalleryImage(gallery);
                _galleryService.SaveImage();

            }
            return RedirectToAction("Index");

        }

        //Delete multiple images
        public ActionResult DeleteImages()
        {

            return View(_galleryService.GetHomepageImages());

        }
        [HttpPost]
        public ActionResult DeleteImages(IEnumerable<int> ImageIds)
        {
            foreach (var id in ImageIds)
            {
                var image = _galleryService.GetGalleryImageById(id);
                string imgPath = Server.MapPath(image.ImagePath);
                _galleryService.DeleteGalleyImage(image);
                if (System.IO.File.Exists(imgPath))
                    System.IO.File.Delete(imgPath);
             }
            _galleryService.SaveImage();             
        
            return RedirectToAction("DeleteGalleryImages");
        }
    }
}