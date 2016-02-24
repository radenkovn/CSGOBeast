namespace CSGOBeast.Web.Areas.Games.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CSGOBeast.Web.Controllers;
    using Services.Data;
    using Infrastructure.Mapping;
    using Models.CoinFlips;
    using Microsoft.AspNet.Identity;
    [Authorize]
    public class CoinFlipsController : BaseController
    {
        private ICoinFlipsService coinflips;
        private IUsersService users;

        public CoinFlipsController(ICoinFlipsService coinflips, IUsersService users)
        {
            this.coinflips = coinflips;
            this.users = users;
        }

        public ActionResult Current()
        {
            var userId = this.User.Identity.GetUserId();
            var userBalance = this.users.GetById(userId).Balance;
            var coinflips = this.coinflips.GetCurrent().To<CurrentCoinFlipViewModel>().ToList();

            var viewModel = new CurrentViewModel
            {
                CoinFlips = coinflips,
                Balance = userBalance,
                
            };

            return this.View(viewModel);
        }
    }
}
