﻿namespace CSGOBeast.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Common;
    using Infrastructure.Mapping;
    using Microsoft.AspNet.Identity;
    using Services.Data;
    using ViewModels.Shop;

    public class ShopController : BaseController
    {
        private const int DefaultPageSize = 12;
        private IItemsService items;
        private IUsersService users;

        public ShopController(IItemsService items, IUsersService users)
        {
            this.items = items;
            this.users = users;
        }

        public ActionResult Items(int id = 1, string name = null, string minPrice = null, string maxPrice = null, string groupType = null, string quality = null, string weaponType = null, string classification = null, string order = null)
        {
            var viewModel = new ShopViewModel();
            if (this.User.Identity.IsAuthenticated)
            {
                var userId = this.User.Identity.GetUserId();
                var user = this.users.GetById(userId);
                var userViewModel = this.Mapper.Map<ShopUserViewModel>(user);
                viewModel.User = userViewModel;
            }

            var items = this.Cache.Get(
                GlobalConstants.ItemsInfoCache,
                () => this.items.GetPublic().To<ShopItemViewModel>().ToList(),
                30);
            if (order != null)
            {
                items = order == "highestprice" ? items.OrderByDescending(x => x.Price).ToList() : items = items.OrderBy(x => x.Price).ToList();
            }

            var itemsToDisplay = items
                .Where(x => string.IsNullOrEmpty(name) ? true : x.Name.ToLower().Contains(name.ToLower()))
                .Where(x => string.IsNullOrEmpty(minPrice) ? true : (x.Price >= decimal.Parse(minPrice)))
                .Where(x => string.IsNullOrEmpty(maxPrice) ? true : (x.Price <= decimal.Parse(maxPrice)))
                .Where(x => string.IsNullOrEmpty(groupType) ? true : ((int)x.GroupType == int.Parse(groupType)))
                .Where(x => string.IsNullOrEmpty(quality) ? true : ((int)x.Quality == int.Parse(quality)))
                .Where(x => string.IsNullOrEmpty(weaponType) ? true : ((int)x.WeaponType == int.Parse(weaponType)))
                .Where(x => string.IsNullOrEmpty(classification) ? true : ((int)x.Classification == int.Parse(classification)))
                .ToList();

            var page = id;
            var allItemsCount = itemsToDisplay.Count();
            var itemsToSkip = (page - 1) * DefaultPageSize;
            var totalPages = (int)Math.Ceiling(allItemsCount / (decimal)DefaultPageSize);

            itemsToDisplay = itemsToDisplay
                .Skip(itemsToSkip)
                .Take(DefaultPageSize)
                .ToList();

            viewModel.Items = itemsToDisplay;
            viewModel.CurrentPage = page;
            viewModel.TotalPages = totalPages;

            return this.View(viewModel);
        }
    }
}
