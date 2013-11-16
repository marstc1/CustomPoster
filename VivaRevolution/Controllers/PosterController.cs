using System;
using System.Linq;
using System.Web.Mvc;
using VivaRevolution.Domain.Abstract;
using VivaRevolution.Domain.Entities;
using VivaRevolution.Models.ViewModels;

namespace VivaRevolution.Controllers
{
    public class PosterController : Controller
    {
        private IPosterRepository repository;
        
        public PosterController(IPosterRepository repo)
        {
            this.repository = repo;
        }
        
        public ActionResult Index()
        {
            PosterViewModel vm = new PosterViewModel
            {
                ImgId = "dv",
                Quote = "when I invented the death star, I didnt have to ask anyones permission",
                Name = "darth vader",
                Title = "sith lord, supreme commander",
                TagLine = "Join the dark side"
            };

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(string quote, string name, string title, string imgCat, string imgId, string tagline)
        {
            Poster poster = new Poster
            {
                Quote = (!String.IsNullOrEmpty(quote)) ? quote.ToUpper() : string.Empty,
                Name = (!String.IsNullOrEmpty(name)) ? name.ToUpper() : string.Empty,
                Title = (!String.IsNullOrEmpty(title)) ? string.Format(" - {0}", title.ToUpper()) : string.Empty,
                ImgCat = (!String.IsNullOrEmpty(imgCat)) ? imgCat : string.Empty,
                ImgId = (!String.IsNullOrEmpty(imgId)) ? imgId : "tb",
                TagLine = (!String.IsNullOrEmpty(tagline)) ? tagline : "Join the digital revolution",
                Private = false,
                PrivateKey = String.Empty,
                CreatedBy = "MARSTC1",
                DateCreated = DateTime.Now
            };
            
            repository.SavePoster(poster);
            
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

        public ActionResult Latest()
        {
            PosterListViewModel vm = new PosterListViewModel(repository.Posters);

            vm.Posters = vm.Posters.OrderByDescending(x => x.DateCreated);
            
            return View("List", vm);
        }

        public ActionResult TopRated()
        {
            IQueryable<Poster> vm = repository.Posters;

            return View("List", vm);
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
