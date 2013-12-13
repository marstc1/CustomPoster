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
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Original" });
            list.Add(new PosterImage { ImageValue = "sj", ImageName = "Steve Jobs" });
            list.Add(new PosterImage { ImageValue = "tb", ImageName = "Tim Berners-Lee" });
            list.Add(new PosterImage { ImageValue = "jb", ImageName = "Jeff Bezos" });
            list.Add(new PosterImage { ImageValue = "ji", ImageName = "Jonathan Ive" });
            list.Add(new PosterImage { ImageValue = "lt", ImageName = "Linus Torvalds" });
            list.Add(new PosterImage { ImageValue = "mz", ImageName = "Mark Zuckerberg" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Star Wars" });
            list.Add(new PosterImage { ImageValue = "dv", ImageName = "Darth Vader" });
            list.Add(new PosterImage { ImageValue = "hs", ImageName = "Han Solo" });
            list.Add(new PosterImage { ImageValue = "r2", ImageName = "R2D2" });
            list.Add(new PosterImage { ImageValue = "st", ImageName = "Storm Trooper" });
            list.Add(new PosterImage { ImageValue = "yd", ImageName = "Yoda" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "A-Team" });
            list.Add(new PosterImage { ImageValue = "ba", ImageName = "Mr T" });
            list.Add(new PosterImage { ImageValue = "hsm", ImageName = "George Peppard" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Music" });
            list.Add(new PosterImage { ImageValue = "bd", ImageName = "Bob Dylan" });
            list.Add(new PosterImage { ImageValue = "dg", ImageName = "Dave Grohl" });
            list.Add(new PosterImage { ImageValue = "jl", ImageName = "John Lennon" });
            list.Add(new PosterImage { ImageValue = "bm", ImageName = "Bob Marley" });
            list.Add(new PosterImage { ImageValue = "mj", ImageName = "Mick Jagger" });
            list.Add(new PosterImage { ImageValue = "tj", ImageName = "Tom Jones" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Movies" });
            list.Add(new PosterImage { ImageValue = "ce", ImageName = "Clint Eastwood" });
            list.Add(new PosterImage { ImageValue = "cn", ImageName = "Chuck Norris" });
            list.Add(new PosterImage { ImageValue = "doc", ImageName = "Doc Emmett Brown" });
            list.Add(new PosterImage { ImageValue = "McFly", ImageName = "Marty McFly" });
            list.Add(new PosterImage { ImageValue = "mg", ImageName = "Mel Gibson" });
            list.Add(new PosterImage { ImageValue = "J5", ImageName = "Johnny 5" });
            list.Add(new PosterImage { ImageValue = "rc", ImageName = "Robocop" });
            list.Add(new PosterImage { ImageValue = "as", ImageName = "Terminator" });
            list.Add(new PosterImage { ImageValue = "bw", ImageName = "Bruce Willis" });
            list.Add(new PosterImage { ImageValue = "shrek", ImageName = "Shrek" });
            list.Add(new PosterImage { ImageValue = "donkey", ImageName = "Donkey" });
            list.Add(new PosterImage { ImageValue = "tcruise", ImageName = "Tom Cruise" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "TV" });
            list.Add(new PosterImage { ImageValue = "fonz", ImageName = "Fonzie" });
            list.Add(new PosterImage { ImageValue = "gc", ImageName = "Wynne Evans" });
            list.Add(new PosterImage { ImageValue = "zippy", ImageName = "Zippy" });
            list.Add(new PosterImage { ImageValue = "dlk", ImageName = "Darlek" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Muppets" });
            list.Add(new PosterImage { ImageValue = "kermit", ImageName = "Kermit" });
            list.Add(new PosterImage { ImageValue = "kermit2c", ImageName = "Kermit - Ripping the poster" });
            list.Add(new PosterImage { ImageValue = "elmo", ImageName = "Elmo" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Comedy" });
            list.Add(new PosterImage { ImageValue = "pn", ImageName = "Pony" });
            list.Add(new PosterImage { ImageValue = "fotcBm", ImageName = "Brett McKenzie" });
            list.Add(new PosterImage { ImageValue = "fotcJc", ImageName = "Jemaine Clement" });
            list.Add(new PosterImage { ImageValue = "am", ImageName = "Alexander Meerkat" });
            list.Add(new PosterImage { ImageValue = "db", ImageName = "David Brent" });
            list.Add(new PosterImage { ImageValue = "eh", ImageName = "Earl Hickey" });
            list.Add(new PosterImage { ImageValue = "hh", ImageName = "Hulk Hogan" });
            list.Add(new PosterImage { ImageValue = "kl", ImageName = "Keith Lemon" });
            list.Add(new PosterImage { ImageValue = "tc", ImageName = "Tommy Cooper" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Sci-Fi" });
            list.Add(new PosterImage { ImageValue = "jlp", ImageName = "Capt Kirk" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Technology" });
            list.Add(new PosterImage { ImageValue = "bg", ImageName = "Bill Gates" });
            list.Add(new PosterImage { ImageName = " " });

            list.Add(new PosterImage { ImageName = "Other" });
            list.Add(new PosterImage { ImageValue = "dc", ImageName = "David Cameron" });
            list.Add(new PosterImage { ImageValue = "kitch", ImageName = "Lord Kitchener" });
            list.Add(new PosterImage { ImageName = " " });

            return list;
        }
    }
}