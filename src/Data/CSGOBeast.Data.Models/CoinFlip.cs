namespace CSGOBeast.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CoinFlip
    {
        public string CreatorId { get; set; }

        public User Creator { get; set; }

        public string PlayerId { get; set; }

        public User Player { get; set; }

        public CoinFlipWin Win { get; set; }
    }
}
