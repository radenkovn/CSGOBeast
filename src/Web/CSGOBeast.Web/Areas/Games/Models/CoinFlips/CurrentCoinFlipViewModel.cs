namespace CSGOBeast.Web.Areas.Games.Models.CoinFlips
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using CSGOBeast.Data.Models;
    using CSGOBeast.Web.Infrastructure.Mapping;

    public class CurrentCoinFlipViewModel : IMapFrom<CoinFlip>
    {
        public string CreatorId { get; set; }

        public virtual User Creator { get; set; }

        public decimal CreatorSum { get; set; }

        public string PlayerId { get; set; }

        public virtual User Player { get; set; }

        public decimal PlayerSum { get; set; }

        public CoinFlipWin Win { get; set; }
    }
}
