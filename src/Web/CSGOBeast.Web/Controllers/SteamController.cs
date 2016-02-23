namespace CSGOBeast.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Mvc;
    using Common;
    using Data;
    using Data.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Owin.Security.Providers.Steam;

    public class SteamController : BaseController
    {
        public string GetSteamID()
        {
            // service
            var manager = new UserManager<User>(new UserStore<User>(new CSGOBeastDBContext()));
            var currentUser = manager.FindById(this.User.Identity.GetUserId());
            if (this.User.Identity.Name != string.Empty)
            {
                string url = currentUser.Logins.First().ProviderKey;

                // here we going to split the providerkey so we get the right part
                this.ViewBag.steamid = url.Split('/')[5];
            }
            else
            {
                this.ViewBag.steamid = string.Empty;
            }

            return this.ViewBag.steamid;
        }

        [HttpGet]
        public ContentResult GetProfile()
        {
            string url = string.Format("http://api.steampowered.com/ISteamUser/GetPlayerSummaries/v0002/?key={0}&steamids={1}", GlobalConstants.SteamApplicationKey, this.GetSteamID());
            string result = null;

            using (var client = new WebClient())
            {
                result = client.DownloadString(url);
            }

            return this.Content(result, "application/json");
        }
    }
}
