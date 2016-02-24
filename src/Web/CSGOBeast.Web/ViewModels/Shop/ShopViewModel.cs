namespace CSGOBeast.Web.ViewModels.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ShopViewModel
    {
        public ShopUserViewModel User { get; set; }

        public IEnumerable<ShopItemViewModel> Items { get; set; }
    }
}
