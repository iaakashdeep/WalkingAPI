using Microsoft.EntityFrameworkCore;
using WalkingAPI.Model.Domain;

namespace WalkingAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
            
        }


        //DbContext is the bridge between Model and DB, track changes and maintaining connections to DB

        public DbSet<Walk> Walks { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
    }
}
