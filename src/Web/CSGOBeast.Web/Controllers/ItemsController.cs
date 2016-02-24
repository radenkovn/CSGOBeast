namespace CSGOBeast.Web.Controllers
{
    using Services.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using ViewModels.Items;
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