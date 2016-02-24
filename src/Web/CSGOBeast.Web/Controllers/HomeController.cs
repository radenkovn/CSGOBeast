﻿namespace CSGOBeast.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Infrastructure.Mapping;
    using Owin.Security.Providers.Steam;

    // using Services.Data;
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
