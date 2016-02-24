namespace CSGOBeast.Data.Models
{
    using System.Collections.Generic;
    using Common.Models;

    public class Item : BaseModel<int>
    {
        private ICollection<User> users;
        private ICollection<CoinFlip> coinflips;

        public Item()
        {
            this.users = new HashSet<User>();
            this.coinflips = new HashSet<CoinFlip>();
        }

        public string Name { get; set; }

        public string ImageLink { get; set; }

        public decimal Price { get; set; }

        public ItemQuality Quality { get; set; }

        public GroupType GroupType { get; set; }

        public WeaponType WeaponType { get; set; }

        public ItemClassification Classification { get; set; }

        public bool Bought { get; set; }

        public virtual ICollection<User> Users
        {
            get { return this.users; } set { this.users = value; }
        }

        public virtual ICollection<CoinFlip> Coinflips
        {
            get
            {
                return this.coinflips;
            }

            set
            {
                this.coinflips = value;
            }
        }
    }
}
