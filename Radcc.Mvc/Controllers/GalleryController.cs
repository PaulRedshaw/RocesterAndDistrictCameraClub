using Radcc.Model.Models;
using Radcc.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Radcc.Mvc.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IGalleryService _galleryService;
        public GalleryController(IGalleryService galleryService)
        {
            this._galleryService = galleryService;     

        }
        
        // GET: Gallery
        public ActionResult SliderPartial()
        {
      
            return View(this._galleryService.GetHomepageImages());
        }
       
    }
}