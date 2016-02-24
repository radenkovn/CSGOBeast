using CSGOBeast.Data.Common;
using CSGOBeast.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSGOBeast.Services.Data
{
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
            var itemToAdd = this.items.GetById(itemId);
            if (currentUser.Balance >= itemToAdd.Price)
            {
                currentUser.Items.Add(itemToAdd);
                this.users.Update(currentUser);
                //this.items.Save();
                this.users.SaveChanges();
            }
            return currentUser;
        }
    }
}
