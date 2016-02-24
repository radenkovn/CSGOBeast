namespace CSGOBeast.Web.Areas.Games.Models.CoinFlips
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Data.Models;
    using Infrastructure.Mapping;

    public class CoinFlipItemViewModel : IMapFrom<Item>
    {
        public decimal Price { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
