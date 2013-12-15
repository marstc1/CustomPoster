using StructureMap;
using System;
using System.Linq;
using System.Web.Mvc;
using VivaRevolution.Domain.Abstract;
using VivaRevolution.Domain.Entities;
using VivaRevolution.Models.ViewModels;
using VivaRevolution.Services.Abstract;

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
            GetLoginName();
            
            IndexViewModel vm = new IndexViewModel(this.repository);

            return View(vm);
        }

        [HttpPost]
        public ActionResult Index(Poster poster, string post, string password)
        {
            if (post != null && password == "poster")
            {
                repository.SavePoster(poster);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Index", new IndexViewModel(this.repository));
            }
        }

        public ActionResult View(int id, string key)
        {
            Poster vm = repository.Posters.FirstOrDefault(x => x.PosterId == id);

            if (vm == null || (vm.PrivateKey != null && vm.PrivateKey != key))
            {
                vm = new Poster
                {
                    Quote = "THESE ARE NOT THE DROIDS YOU'RE LOOKING FOR",
                    Name = "Storm Trooper",
                    Title = "",
                    ImgCat = "",
                    ImgId = "st",
                    TagLine = "404 Not found!"
                };
            }

            ViewBag.URL = Request.Url.ToString();

            return View("View", vm);
        }

        [HttpPost]
        public ActionResult _Preview(Poster poster)
        {
            return PartialView("_poster", poster);
        }

        [HttpPost]
        public ActionResult _Latest()
        {
            IQueryable<Poster> vm = repository.Posters;

            vm = vm.OrderByDescending(x => x.DateCreated);

            return PartialView("_listOfPosters", vm);
        }

        private static string GetLoginName()
        {
            IChallengeResponseService userservice = ObjectFactory.GetInstance<IChallengeResponseService>();
            string userid = userservice.Invoke();
            return userid;
        }
    }
}
