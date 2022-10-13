using csharp_boolflix.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace csharp_boolflix.Context
{
    public class MyContext : IdentityDbContext<IdentityUser>
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<TVSeries> TVSeries { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<MediaInfo> MediaInfos { get; set; }
        public DbSet<Classification> Classifications { get; set; }

        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=boolflix_db;Integrated Security=True");
        }
    }
}
