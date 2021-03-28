namespace CampingRusevi.Web.Areas.Administration.Controllers
{
    using CampingRusevi.Common;
    using CampingRusevi.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
