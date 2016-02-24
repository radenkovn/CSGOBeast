namespace CSGOBeast.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Common.Models;

    public class CoinFlip : BaseModel<int>
    {
        private ICollection<Item> creatorItems;
        private ICollection<Item> playerItems;

        public CoinFlip()
        {
            this.creatorItems = new HashSet<Item>();
            this.playerItems = new HashSet<Item>();
        }

        public string CreatorId { get; set; }

        public virtual User Creator { get; set; }

        public decimal CreatorSum { get; set; }

        public string PlayerId { get; set; }

        public virtual User Player { get; set; }

        public CoinFlipWin Win { get; set; }

        public virtual ICollection<Item> CreatorItems
        {
            get
            {
                return this.creatorItems;
            }

            set
            {
                this.creatorItems = value;
            }
        }

        public virtual ICollection<Item> PlayerItems
        {
            get
            {
                return this.playerItems;
            }

            set
            {
                this.playerItems = value;
            }
        }
    }
}
