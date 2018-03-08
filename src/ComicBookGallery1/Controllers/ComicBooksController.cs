using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery1.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Final issue! Witness the final hour</p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delagdo",
                "Letters: Chris Eliopoulos"
            };

            return View();
            
        }
    }
}