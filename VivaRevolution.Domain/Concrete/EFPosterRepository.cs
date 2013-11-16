using System;
using System.Linq;
using VivaRevolution.Domain.Abstract;
using VivaRevolution.Domain.Entities;

namespace VivaRevolution.Domain.Concrete
{
    public class EFPosterRepository : IPosterRepository
    {
        private EFDbContext context = new EFDbContext();

        public IQueryable<Poster> Posters
        {
            get { return context.Posters; }
        }

        public void SavePoster(Poster poster)
        {
            context.Posters.Add(poster);

            context.SaveChanges();
        }

        public void DeletePoster(Poster poster)
        {
            throw new NotImplementedException();
        }
    }
}
