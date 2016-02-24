namespace CSGOBeast.Web.Areas.Games.Models.CoinFlips
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class CurrentViewModel
    {
        public IEnumerable<CurrentCoinFlipViewModel> CoinFlips { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

        public decimal Balance { get; set; }
    }
}