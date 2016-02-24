namespace CSGOBeast.Web.Areas.Games.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CSGOBeast.Web.Controllers;
    using Services.Data;

    [Authorize]
    public class CoinFlipsController : BaseController
    {
        private ICoinFlipsService coinflips;

        public CoinFlipsController(ICoinFlipsService coinflips)
        {
            this.coinflips = coinflips;
        }

        public ActionResult Current()
        {
            var coinflips = this.coinflips.GetCurrent();

            return this.View();
        }
    }
}
