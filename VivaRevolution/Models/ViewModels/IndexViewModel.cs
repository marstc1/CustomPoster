using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VivaRevolution.Domain.Entities;
using VivaRevolution.Models.Mappers;

namespace VivaRevolution.Models.ViewModels
{
    public class IndexViewModel
    {
        public Poster FeaturePoster { get; set; }

        public PosterListViewModel FeaturePosters { get; set; }
    }
}