using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VivaRevolution.Domain.Entities;

namespace VivaRevolution.Models.ViewModels
{
    public class PosterListViewModel
    {
        private IQueryable<Poster> posters;

        public PosterListViewModel(IQueryable<Poster> posters)
        {
            this.posters = posters;
        }

        public IQueryable<Poster> Posters 
        {
            get
            {
                return this.posters;
            }
            set
            {
                this.posters = value;
            }
        }
    }
}