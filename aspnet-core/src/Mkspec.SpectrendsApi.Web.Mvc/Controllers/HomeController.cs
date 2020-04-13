using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Mkspec.SpectrendsApi.Controllers;

namespace Mkspec.SpectrendsApi.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : SpectrendsApiControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
