namespace CSGOBeast.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSGOBeast.Data.Common;
    using CSGOBeast.Data.Models;

    public class UsersService : IUsersService
    {
        private IUsersRepository<User> users;
        private IDbRepository<Item> items;

        public UsersService(IUsersRepository<User> users, IDbRepository<Item> items)
        {
            this.users = users;
            this.items = items;
        }

        public User GetById(string id)
        {
            return this.users.GetById(id);
        }

        public User Buy(string userId, int itemId)
        {
            var currentUser = this.users.GetById(userId);
            if (currentUser != null)
            {
                var itemToAdd = this.items.GetById(itemId);
                if (itemToAdd != null)
                {
                    if (currentUser.Balance >= itemToAdd.Price)
                    {
                        currentUser.Balance -= itemToAdd.Price;
                        currentUser.Items.Add(itemToAdd);
                        itemToAdd.Price *= 0.95m;
                        itemToAdd.Bought = true;
                        this.users.Update(currentUser);
                        this.items.Save();
                        this.users.SaveChanges();
                    }

                    return currentUser;
                }
            }

            return null;
        }

        public User Sell(string userId, int itemId)
        {
            var currentUser = this.users.GetById(userId);
            if (currentUser != null)
            {
                var itemToAdd = currentUser.Items.FirstOrDefault(x => x.Id == itemId);
                if (itemToAdd != null)
                {
                    currentUser.Balance += itemToAdd.Price;
                    currentUser.Items.Add(itemToAdd);
                    itemToAdd.Price *= 1.05m;
                    itemToAdd.Bought = false;
                    currentUser.Items.Remove(itemToAdd);
                    this.users.Update(currentUser);
                    this.items.Save();
                    this.users.SaveChanges();
                    return currentUser;
                }
            }

            return null;
        }
    }
}
