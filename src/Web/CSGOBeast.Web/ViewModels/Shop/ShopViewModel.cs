namespace CSGOBeast.Web.ViewModels.Shop
{
    using Data.Models;
    using Shared;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ShopViewModel : PageableModel
    {
        public ShopViewModel()
        {
            this.CurrentPage = 1;
            this.TotalPages = 1;
        }

        public ShopUserViewModel User { get; set; }

        public IEnumerable<ShopItemViewModel> Items { get; set; }

        public ItemQuality? Quality { get; set; }

        public GroupType? GroupType { get; set; }

        public WeaponType? WeaponType { get; set; }

        public ItemClassification? Classification { get; set; }
    }
}
