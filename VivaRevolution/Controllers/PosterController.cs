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
        public ActionResult Index(Poster poster, string preview, string post)
        {
            if (preview != null)
            {
                return View("Preview", poster);
            }

            else if (post != null)
            {
                poster.CreatedBy = GetLoginName();

                repository.SavePoster(poster);

                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
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

            return View("View", vm);
        }

        [HttpPost]
        public ActionResult _Preview(Poster poster)
        {
            return PartialView("_poster", poster);
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

        private static string GetLoginName()
        {
            IChallengeResponseService userservice = ObjectFactory.GetInstance<IChallengeResponseService>();
            string userid = userservice.Invoke();
            return userid;
        }
    }
}
