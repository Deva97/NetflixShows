using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetflixShows.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace NetflixShows.Context
{
    public class SeriesDbContext : DbContext
    {
        public DbSet<Series> Seriess { get; set; }
        public SeriesDbContext(DbContextOptions<SeriesDbContext>options):
            base(options) 
        {
        }
    }

}
