using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using RyanPolterSite.Models;

namespace RyanPolterSite
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
           DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //  Each of these sets represents a table
        //  The type should be plural while the object is singular (I've just been usiong "Stories" for the whole project so i kept it)
        public DbSet<StoriesModel> Stories { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        //public DbSet<AppUser> AppUsers { get; set; }
    }
}
