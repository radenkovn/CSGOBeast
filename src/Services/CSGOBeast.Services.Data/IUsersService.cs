namespace CSGOBeast.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CSGOBeast.Data.Common;
    using CSGOBeast.Data.Models;

    public interface IUsersService
    {
        User GetById(string id);

        User Buy(string userId, int itemId);
    }
}
