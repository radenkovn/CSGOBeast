namespace CSGOBeast.Services.Data
{
    using CSGOBeast.Data.Common;
    using CSGOBeast.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IUsersService
    {
        User GetById(string id);
    }
}
