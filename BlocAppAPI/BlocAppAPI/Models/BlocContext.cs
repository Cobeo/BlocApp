using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlocAppAPI.Models
{
    public class BlocContext : DbContext
    {
        public BlocContext(DbContextOptions<BlocContext> options)
            : base(options)
        {
        }

        public DbSet<Bloc> Blocs { get; set; }

        public DbSet<Cotation> Cotations { get; set; }
    }
}
