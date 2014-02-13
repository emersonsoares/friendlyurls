using FriendlyUrls.Web.Models;

namespace FriendlyUrls.Web.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var notice1 = Notice.New("awesome-notice", "Awesome Notice", "Lorem Ipsum Dolor Sit Amet");
            notice1.Id = 1;

            var notice2 = Notice.New("tragic-notice", "Tragic Notice", "Lorem Ipsum Dolor Sit Amet");
            notice2.Id = 2;

            var notice3 = Notice.New("strange-notice-sample", "This a strange notice", "Lorem Ipsum Dolor Sit Amet");
            notice3.Id = 3;

            context.Notices.AddOrUpdate(notice1);
            context.Notices.AddOrUpdate(notice2);
            context.Notices.AddOrUpdate(notice3);
            context.SaveChanges();
        }
    }
}
