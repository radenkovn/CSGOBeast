namespace CSGOBeast.Web.ViewModels.Inventory
{
    using System.Collections.Generic;
    using CSGOBeast.Data.Models;
    using CSGOBeast.Web.Infrastructure.Mapping;
    using Items;

    public class UserInventoryViewModel : IMapFrom<User>
    {
        public decimal Balance { get; set; }

        public IEnumerable<ItemDetailsViewModel> Items { get; set; }
    }
}
