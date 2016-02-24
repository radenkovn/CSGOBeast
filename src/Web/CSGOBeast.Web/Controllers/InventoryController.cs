namespace CSGOBeast.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Common;
    using CSGOBeast.Services.Data;
    using Microsoft.AspNet.Identity;
    using ViewModels.Inventory;
    using ViewModels.Items;

    [Authorize]
    public class InventoryController : BaseController
    {
        private IItemsService items;
        private IUsersService users;

        public InventoryController(IItemsService items, IUsersService users)
        {
            this.items = items;
            this.users = users;
        }

        public ActionResult Inventory()
        {
            var userId = this.User.Identity.GetUserId();
            var user = this.users.GetById(userId);
            var viewModel = this.Mapper.Map<UserInventoryViewModel>(user);

            return this.View(viewModel);
        }

        public ActionResult BuyItem(BuyModel item)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Shop/Items");
            }

            var userId = this.User.Identity.GetUserId();

            var user = this.users.Buy(userId, item.ItemId);
            this.Cache.Remove(GlobalConstants.ItemsInfoCache);

            var viewModel = this.Mapper.Map<UserInventoryViewModel>(user);

            return this.Redirect("/Inventory/");
        }

        public ActionResult SellItem(SellModel item)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Shop/Items");
            }

            var userId = this.User.Identity.GetUserId();
            var user = this.users.Sell(userId, item.ItemId);

            this.Cache.Remove(GlobalConstants.ItemsInfoCache);

            return this.Redirect("/Inventory/");
        }
    }
}