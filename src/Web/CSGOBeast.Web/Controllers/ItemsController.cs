namespace CSGOBeast.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Services.Data;
    using ViewModels.Items;

    [Authorize]

    public class ItemsController : BaseController
    {
        private IItemsService items;

        public ItemsController(IItemsService items)
        {
            this.items = items;
        }

        public ActionResult Details(int id)
        {
            var item = this.items.GetById(id);
            var viewModel = this.Mapper.Map<ItemDetailsViewModel>(item);

            return this.View(viewModel);
        }
    }
}
