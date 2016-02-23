namespace CSGOBeast.Web.ViewModels.SteamUsers
{
    using System.Collections.Generic;

    public class UsersResponse
    {
        public IEnumerable<SteamUser> Players { get; set; }
    }
}
