using System;
using System.Web.Mvc;
using VivaRevolution.Models.ViewModels;

namespace VivaRevolution.Controllers
{
    public class PosterController : Controller
    {
        public ActionResult Index()
        {
            PosterViewModel vm = new PosterViewModel
            {
                ImgId = "tb",
                Quote = "WHEN I INVENTED THE WEB, I DIDNT HAVE TO ASK ANYONES PERMISSION",
                Name = "SIR TIM BERNERS-LEE",
                Title = " - INVENTOR OF THE WORLD WIDE WEB",
                TagLine = "Join the digital revolution"
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(string imgId, string quote, string name, string title, string tagline)
        {
            return RedirectToAction("View", new { @ImgId = imgId, @Quote = quote, @Name = name, @Title = title, @TagLine = tagline });
        }

        public ActionResult View(string quote, string name, string title, string imgCat, string imgId, string tagline)
        {
            PosterViewModel vm = new PosterViewModel
            {
                Quote = (!String.IsNullOrEmpty(quote)) ? quote.ToUpper() : string.Empty,
                Name = (!String.IsNullOrEmpty(name)) ? name.ToUpper(): string.Empty,
                Title = (!String.IsNullOrEmpty(title)) ? string.Format(" - {0}", title.ToUpper()) : string.Empty,
                ImgCat = (!String.IsNullOrEmpty(imgCat)) ? imgCat : string.Empty,
                ImgId = (!String.IsNullOrEmpty(imgId)) ? imgId : "tb",
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
