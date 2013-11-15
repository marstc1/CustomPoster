using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VivaRevolution.Models.Mappers
{
    public class PosterViewModelMapper
    {       
        public List<PosterImage> CreatePosterImagesDropDownValues() {
            List<PosterImage> list = new List<PosterImage>();

            list.Add(new PosterImage { ImageValue = "sj", ImageName = "Steve Jobs" });
            list.Add(new PosterImage { ImageValue = "tb", ImageName = "Tim Berners-Lee" });
            list.Add(new PosterImage { ImageValue = "dv", ImageName = "Darth Vader" });
            list.Add(new PosterImage { ImageValue = "hs", ImageName = "Han Solo" });
            list.Add(new PosterImage { ImageValue = "r2", ImageName = "R2D2" });
            list.Add(new PosterImage { ImageValue = "st", ImageName = "Storm Trooper" });
            list.Add(new PosterImage { ImageValue = "yd", ImageName = "Yoda" });
            list.Add(new PosterImage { ImageValue = "ba", ImageName = "Mr T" });
            list.Add(new PosterImage { ImageValue = "hsm", ImageName = "George Peppard" });
            list.Add(new PosterImage { ImageValue = "bd", ImageName = "Bob Dylan" });

            return list;
        }
    }
}