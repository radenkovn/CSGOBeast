namespace CSGOBeast.Web.Areas.Games.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using CSGOBeast.Web.Controllers;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Models.CoinFlips;
    using Services.Data;

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
                Balance = userBalance
            };

            return this.View(viewModel);
        }

        [ValidateAntiForgeryToken]
        public ActionResult CompleteCoinFlip(CompleteCoinFlipViewModel model)
        {

            var userId = this.User.Identity.GetUserId();
            if (!this.ModelState.IsValid)
            {
                this.RedirectToAction("Current", "CoinFlips");
            }

            var userBalance = this.users.GetById(userId).Balance;
            var coinflips = this.coinflips.CompleteCoinFlip(model.Id, userId).To<CurrentCoinFlipViewModel>().ToList();

            var viewModel = new CurrentViewModel
            {
                CoinFlips = coinflips,
                Balance = userBalance
            };

            return this.RedirectToAction("Current", "CoinFlips");
        }
    }
}
