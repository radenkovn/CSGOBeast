namespace CSGOBeast.Web.ViewModels.Shop
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ShopViewModel
    {
        public IEnumerable<ShopItemViewModel> Items { get; set; }
    }
}
