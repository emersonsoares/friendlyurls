using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FriendlyUrls.Web.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public DbSet<Notice> Notices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Notice>().Property(x => x.Slug).IsRequired().HasMaxLength(255);
            modelBuilder.Entity<Notice>().Property(x => x.Title).IsRequired().HasMaxLength(255);

            base.OnModelCreating(modelBuilder);
        }
    }
}