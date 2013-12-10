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

        public IQueryable<Poster> AllPosters {
            get
            {
                return repository.Posters;
            }
        }

        public List<Poster> FeaturePosters {
            get 
            {
                return repository.Posters.OrderBy(x => Guid.NewGuid()).Take(3).ToList();
            }
        }

        public IQueryable<Poster> LatestPosters
        {
            get
            {
                return repository.Posters.OrderByDescending(x => x.DateCreated).Take(6);
            }
        }

        public IQueryable<Poster> TopRatedPosters
        {
            get
            {
                return repository.Posters.OrderBy(x => x.DateCreated).Take(3);
            }
        }
    }
}