using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ComicBookGallary.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();
        }
    }
}