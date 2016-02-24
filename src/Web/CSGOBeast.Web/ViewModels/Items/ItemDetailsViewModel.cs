namespace CSGOBeast.Web.ViewModels.Items
{
    using CSGOBeast.Data.Models;
    using CSGOBeast.Web.Infrastructure.Mapping;

    public class ItemDetailsViewModel : IMapFrom<Item>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageLink { get; set; }

        public decimal Price { get; set; }

        public ItemQuality Quality { get; set; }

        public GroupType GroupType { get; set; }

        public WeaponType WeaponType { get; set; }

        public ItemClassification Classification { get; set; }

        public BuyModel BuyModel => new BuyModel { ItemId = this.Id };
    }
}