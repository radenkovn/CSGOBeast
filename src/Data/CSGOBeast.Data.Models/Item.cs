namespace CSGOBeast.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Item
    {
        private ICollection<User> users;

        public Item()
        {
            this.users = new HashSet<User>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageLink { get; set; }

        public decimal Price { get; set; }

        public ItemQuality Quality { get; set; }

        public virtual ICollection<User> Users { get { return this.users; } set { this.users = value; } }
    }
}
