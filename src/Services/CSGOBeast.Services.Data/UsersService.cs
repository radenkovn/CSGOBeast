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

        public UsersService(IUsersRepository<User> users)
        {
            this.users = users;
        }

        public User GetById(string id)
        {
            return this.users.GetById(id);
        }
    }
}
