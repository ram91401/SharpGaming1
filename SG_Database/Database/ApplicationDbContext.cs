using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SG_Database.Model;
namespace SharpGaming
{
    public class ApplicationDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(Configuration.GetConnectionString("ConnStr"));
        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Event> Events { get; set; }
        public DbSet<Sport> Sports { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
    }
}
