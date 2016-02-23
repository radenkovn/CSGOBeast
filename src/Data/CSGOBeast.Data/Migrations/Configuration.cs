namespace CSGOBeast.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CSGOBeast.Common;
    using CSGOBeast.Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public sealed class Configuration : DbMigrationsConfiguration<CSGOBeastDBContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(CSGOBeastDBContext context)
        {
            const string AdministratorUserName = "admin@admin.com";
            const string AdministratorPassword = AdministratorUserName;

            if (!context.Roles.Any())
            {
                // Create admin role
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var adminRole = new IdentityRole { Name = GlobalConstants.AdministratorRoleName };
                var userRole = new IdentityRole { Name = GlobalConstants.UserRoleName };
                roleManager.Create(adminRole);
                roleManager.Create(userRole);

                // Create admin user
                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var user = new User { UserName = AdministratorUserName, Email = AdministratorUserName };
                userManager.Create(user, AdministratorPassword);

                // Assign user to admin role
                userManager.AddToRole(user.Id, GlobalConstants.AdministratorRoleName);
            }
        }
    }
}
