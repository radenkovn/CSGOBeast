namespace CSGOBeast.Web.ViewModels.Shop
{
    using Data.Models;
    using Infrastructure.Mapping;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ShopUserViewModel: IMapFrom<User>
    {
        public decimal Balance { get; set; }
    }
}