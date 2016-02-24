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
    using Microsoft.AspNet.Identity;
    using Common;
    [Authorize]
    public class ShopController : BaseController
    {
        private IItemsService items;
        private IUsersService users;

        public ShopController(IItemsService items, IUsersService users)
        {
            this.items = items;
            this.users = users;
        }

        public ActionResult Items()
        {
            var userId = this.User.Identity.GetUserId();
            var user = this.users.GetById(userId);
            var userViewModel = this.Mapper.Map<ShopUserViewModel>(user);
            var items =
            this.Cache.Get(
                GlobalConstants.ItemsInfoCache,
                () => this.items.GetAll().To<ShopItemViewModel>().ToList(),
                30);

            var viewModel = new ShopViewModel
            {
                Items = items,
                User = userViewModel
            };

            return this.View(viewModel);

        }
    }
}
