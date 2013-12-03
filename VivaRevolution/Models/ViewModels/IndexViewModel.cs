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
        
        public IndexViewModel(IPosterRepository repo)
        {
            this.repository = repo;
        }

        public Poster FeaturePoster { get; set; }

        public IQueryable<Poster> AllPosters {
            get
            {
                return repository.Posters;
            }
        }

        public IQueryable<Poster> FeaturePosters {
            get 
            {
                return this.AllPosters.OrderByDescending(x => x.DateCreated).Where(x => x.PosterId >= 2).Take(3);
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