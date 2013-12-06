using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VivaRevolution.Domain.Abstract;
using VivaRevolution.Domain.Entities;
using VivaRevolution.Models.Mappers;

namespace VivaRevolution.Models.ViewModels
{
    public class IndexViewModel
    {
        private IPosterRepository repository;
        private List<Poster> featurePosters;
        private Random r;

        public IndexViewModel(IPosterRepository repo)
        {
            this.repository = repo;
            r = new Random();
        }

        public Poster FeaturePoster { get; set; }

        public IQueryable<Poster> AllPosters {
            get
            {
                return repository.Posters;
            }
        }

        public List<Poster> FeaturePosters {
            get 
            {
                featurePosters = new List<Poster>();
                int maxRandomNo = this.AllPosters.Count() - 1;
                int i;

                while (featurePosters.Count() < 3)
                {
                    i = this.r.Next(maxRandomNo);
                    featurePosters.Add(repository.Posters.FirstOrDefault(x => x.PosterId == i));                    
                }

                return featurePosters;
            }
        }

        public IQueryable<Poster> LatestPosters
        {
            get
            {
                return this.AllPosters.OrderByDescending(x => x.DateCreated).Take(3);
            }
        }

        public IQueryable<Poster> TopRatedPosters
        {
            get
            {
                return this.AllPosters.OrderBy(x => x.DateCreated).Take(3);
            }
        }
    }
}