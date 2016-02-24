namespace CSGOBeast.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CSGOBeast.Services.Data;
    using Microsoft.AspNet.Identity;
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

        public ActionResult BuyItem(BuyModel item)
        {
            if (!this.ModelState.IsValid)
            {
                return this.Redirect("/Shop/Items");
            }

            var userId = this.User.Identity.GetUserId();

            this.users.Buy(userId, item.ItemId);

            return this.View();
        }
    }
}