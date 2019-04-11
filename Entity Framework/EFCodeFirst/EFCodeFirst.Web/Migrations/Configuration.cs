namespace EFCodeFirst.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EFCodeFirst.Web.Models.EFCodeFirstContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EFCodeFirst.Web.Models.EFCodeFirstContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.BlogComments.AddOrUpdate(x => x.BlogCommentId, new Models.BlogComment()
            {
                BlogCommentId = 1,
                Author = "Pablo",
                BlogPostId = 1,
                Content = "Ejemplo Comentario"
            });
        }
    }
}
