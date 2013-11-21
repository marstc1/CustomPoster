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

            list.Add(new PosterImage { ImageValue = "-", ImageName = "--- Original ---" });
            list.Add(new PosterImage { ImageValue = "sj", ImageName = "Steve Jobs" });
            list.Add(new PosterImage { ImageValue = "tb", ImageName = "Tim Berners-Lee" });
            list.Add(new PosterImage { ImageValue = "jb", ImageName = "Jeff Bezos" });
            list.Add(new PosterImage { ImageValue = "ji", ImageName = "Jonathan Ive" });
            list.Add(new PosterImage { ImageValue = "lt", ImageName = "Linus Torvalds" });
            list.Add(new PosterImage { ImageValue = "mz", ImageName = "Mark Zuckerberg" });
            list.Add(new PosterImage { ImageValue = "-", ImageName = "--- Star Wars ---" });
            list.Add(new PosterImage { ImageValue = "dv", ImageName = "Darth Vader" });
            list.Add(new PosterImage { ImageValue = "hs", ImageName = "Han Solo" });
            list.Add(new PosterImage { ImageValue = "r2", ImageName = "R2D2" });
            list.Add(new PosterImage { ImageValue = "st", ImageName = "Storm Trooper" });
            list.Add(new PosterImage { ImageValue = "yd", ImageName = "Yoda" });
            list.Add(new PosterImage { ImageValue = "-", ImageName = "--- A-Team ---" });
            list.Add(new PosterImage { ImageValue = "ba", ImageName = "Mr T" });
            list.Add(new PosterImage { ImageValue = "hsm", ImageName = "George Peppard" });
            list.Add(new PosterImage { ImageValue = "-", ImageName = "--- Music ---" });
            list.Add(new PosterImage { ImageValue = "bd", ImageName = "Bob Dylan" });
            list.Add(new PosterImage { ImageValue = "-", ImageName = "--- Movies ---" });
            list.Add(new PosterImage { ImageValue = "ce", ImageName = "Clint Eastwood" });
            list.Add(new PosterImage { ImageValue = "cn", ImageName = "Chuck Norris" });
            list.Add(new PosterImage { ImageValue = "doc", ImageName = "Doc Emmett Brown" });
            list.Add(new PosterImage { ImageValue = "McFly", ImageName = "Marty McFly" });
            list.Add(new PosterImage { ImageValue = "-", ImageName = "--- Comedy ---" });
            list.Add(new PosterImage { ImageValue = "fotcBm", ImageName = "Brett McKenzie" });
            list.Add(new PosterImage { ImageValue = "fotcJc", ImageName = "Jemaine Clement" });
            list.Add(new PosterImage { ImageValue = "pn", ImageName = "Pony" });

            return list;
        }
    }
}