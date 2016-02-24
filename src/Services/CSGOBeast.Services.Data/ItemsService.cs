namespace CSGOBeast.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSGOBeast.Data.Common;
    using CSGOBeast.Data.Models;

    public class ItemsService : IItemsService
    {
        private IDbRepository<Item> items;

        public ItemsService(IDbRepository<Item> items)
        {
            this.items = items;
        }

        public IQueryable<Item> GetAll()
        {
            return this.items.All();
        }

        public Item GetById(int id)
        {
            return this.items.GetById(id);
        }
    }
}
