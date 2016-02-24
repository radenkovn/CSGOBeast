namespace CSGOBeast.Web.ViewModels.Shop
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Web;
    using Data.Models;
    using Infrastructure.Mapping;

    public class ShopItemViewModel : IMapFrom<Item>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageLink { get; set; }

        public decimal Price { get; set; }

        public ItemQuality Quality { get; set; }

        public GroupType GroupType { get; set; }

        public WeaponType WeaponType { get; set; }

        public ItemClassification Classification { get; set; }
    }
}
