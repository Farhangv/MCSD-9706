namespace PropMan.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PropMan.Models.PropManDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PropMan.Models.PropManDbContext context)
        {
            //context.PropertyTypes.Add(new Models.PropertyType() { Name = "زمین کشاورزی" });
            context.PropertyTypes.AddOrUpdate(
                pt => pt.Name,
                new Models.PropertyType() { Name = "زمین کشاورزی" },
                new Models.PropertyType() { Name = "تجاری" },
                new Models.PropertyType() { Name = "مسکونی" },
                new Models.PropertyType() { Name = "اداری" },
                new Models.PropertyType() { Name = "موقعیت اداری" },
                new Models.PropertyType() { Name = "کلنگی" }
                );

            var store = new RoleStore<IdentityRole>(context);
            var manager = new RoleManager<IdentityRole>(store);

            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var role = new IdentityRole("Admin");
                manager.Create(role);
            }

            if (!context.Roles.Any(r => r.Name == "User"))
            {
                var role = new IdentityRole("User");
                manager.Create(role);
            }
        }
    }
}
