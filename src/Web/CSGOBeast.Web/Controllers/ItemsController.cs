namespace CSGOBeast.Web.Controllers
{
    using Services.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ItemsController : BaseController
    {
        private IItemsService items;

        public ItemsController(IItemsService items)
        {
            this.items = items;
        }
    }
}