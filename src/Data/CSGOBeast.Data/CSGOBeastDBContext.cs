namespace CSGOBeast.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using Common.Models;
    using CSGOBeast.Data.Models;

    using Microsoft.AspNet.Identity.EntityFramework;

    public class CSGOBeastDBContext : IdentityDbContext<User>
    {
        public CSGOBeastDBContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Ticket> Tickets { get; set; }

        public IDbSet<Item> Items { get; set; }

        public static CSGOBeastDBContext Create()
        {
            return new CSGOBeastDBContext();
        }

        public override int SaveChanges()
        {
            this.ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            // Approach via @julielerman: http://bit.ly/123661P
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditInfo && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditInfo)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }
    }
}
