namespace CSGOBeast.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class ErrorsController : BaseController
    {
        public ActionResult Error()
        {
            return this.View();
        }
    }
}