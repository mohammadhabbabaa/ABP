using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Bicisim.Controllers;

namespace Bicisim.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BicisimControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
