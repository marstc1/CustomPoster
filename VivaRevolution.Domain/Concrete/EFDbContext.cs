using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using VivaRevolution.Domain.Entities;

namespace VivaRevolution.Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet<Poster> Posters { get; set; }
    }
}
