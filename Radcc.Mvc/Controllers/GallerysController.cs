
using Radcc.Mvc.ViewModels;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace Radcc.Mvc.Controllers
{
    public class GallerysController : Controller
    {
        // GET: Gallerys
        public ActionResult Index()
        {

            DirectoryInfo di = new DirectoryInfo(Server.MapPath("~/Gallery"));

            var folders = di.GetDirectories().ToList().Select(d => d.Name);
          

            return View(folders);
        }
       
        public virtual ActionResult Files(string subFolder) 
        {

        // FileViewModel contains the root MyFolder and the selected subfolder if any
        FileViewModel model = new FileViewModel() { Folder = "MyFolder", SubFolder = subFolder };

        return View(model);
        }



        
    }
}