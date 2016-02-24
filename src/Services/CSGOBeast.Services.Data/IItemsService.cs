namespace CSGOBeast.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSGOBeast.Data.Models;

    public interface IItemsService
    {
        IQueryable<Item> GetPublic();

        Item GetById(int id);
    }
}
