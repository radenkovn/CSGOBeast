namespace CSGOBeast.Web.Areas.Administration.Controllers
{
    using System.Web.Mvc;

    using CSGOBeast.Common;
    using CSGOBeast.Web.Controllers;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    public class AdministrationController : BaseController
    {
    }
}
