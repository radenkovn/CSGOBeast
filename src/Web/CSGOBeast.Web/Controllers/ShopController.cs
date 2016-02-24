namespace CSGOBeast.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Services.Data;
    using ViewModels.Shop;

    public class ShopController : BaseController
    {
        private IItemsService items;

        public ShopController(IItemsService items)
        {
            this.items = items;
        }

        public ActionResult Items()
        {
            var items =
            this.Cache.Get(
                "categories",
                () => this.items.GetAll().To<ShopItemViewModel>().ToList(),
                30);

            var viewModel = new ShopViewModel
            {
                Items = items
            };

            return this.View(items);

        }
    }
}
