using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaRevolution.Domain.Entities;

namespace VivaRevolution.Domain.Abstract
{
    public interface IPosterRepository
    {
        IQueryable<Poster> Posters { get; }

        void SavePoster(Poster poster);

        void DeletePoster(Poster poster);
    }
}
