namespace CSGOBeast.Web
{
    using System.Data.Entity;
    using Data;
    using Data.Migrations;

    public class DatabaseConfig
    {
        public static void Initialize()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<CSGOBeastDBContext, Configuration>());

            CSGOBeastDBContext.Create().Database.Initialize(true);
        }
    }
}
