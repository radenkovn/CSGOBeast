﻿namespace CSGOBeast.Web.Areas.Games
{
    using System.Web.Mvc;

    public class GamesAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Games";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Games_default",
                "Games/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional });
        }
    }
}
