using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VivaRevolution.Models;

namespace VivaRevolution.Controllers
{
    public class PosterController : Controller
    {
        public ActionResult Index()
        {
            PosterViewModel vm = new PosterViewModel
            {
                ImgId = "tb",
                Quote = "When I invented the web, I didnt have to ask anyones permission",
                Name = "Sir Tim Berners-Lee",
                Title = "Inventor of the world wide web",
                TagLine = "Join the digital revolution"
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(string imgId, string quote, string name, string title, string tagline)
        {
            return RedirectToAction("View", new { @ImgId = imgId, @Quote = quote, @Name = name, @Title = title, @TagLine = tagline });
        }

        public ActionResult View(string imgId, string quote, string name, string title, string tagline)
        {
            PosterViewModel vm = new PosterViewModel
            {
                ImgId = (!String.IsNullOrEmpty(imgId)) ? imgId : "tb",
                Quote = (!String.IsNullOrEmpty(quote)) ? quote.ToUpper() : string.Empty,
                Name = (!String.IsNullOrEmpty(name)) ? name.ToUpper(): string.Empty,
                Title = (!String.IsNullOrEmpty(title)) ? string.Format(" - {0}", title) : string.Empty,
                TagLine = (!String.IsNullOrEmpty(tagline)) ? tagline : "Join the digital revolution",
            };
            
            return View("View", vm);
        }

        public ActionResult Vader()
        {
            string imgId = "dv";
            string quote = "when I invented the death star, I didnt have to ask anyones permission";
            string name = "darth vader";
            string title = "sith lord, supreme commander";
            string tagline = "Join the dark side";

            return RedirectToAction("View", new { @ImgId = imgId, @Quote = quote, @Name = name, @Title = title, @TagLine = tagline });
        }
    }
}
