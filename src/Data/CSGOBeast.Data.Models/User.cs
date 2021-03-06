﻿namespace CSGOBeast.Data.Models
{
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class User : IdentityUser
    {
        private ICollection<Item> items;
        private ICollection<Ticket> tickets;
        private ICollection<CoinFlip> coinflips;

        public User()
        {
            this.items = new HashSet<Item>();
            this.tickets = new HashSet<Ticket>();
            this.coinflips = new HashSet<CoinFlip>();
        }

        public virtual ICollection<Item> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                this.items = value;
            }
        }

        public virtual ICollection<Ticket> Tickets
        {
            get
            {
                return this.tickets;
            }

            set
            {
                this.tickets = value;
            }
        }

        public string TradeLink { get; set; }

        public decimal Balance { get; set; }

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

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
