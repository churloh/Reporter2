namespace Reporter.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Reporter.Users;

    internal sealed class Configuration : DbMigrationsConfiguration<Reporter.EntityFramework.ReporterDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Reporter";
        }

        protected override void Seed(Reporter.EntityFramework.ReporterDbContext context)
        {
            context.Users.AddOrUpdate(p => p.Name, new User { Name = "Admin" });
        }
    }
}
