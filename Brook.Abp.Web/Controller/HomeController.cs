using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Brook.Abp.Web.Controller
{
    public class HomeController : AbpController
    {
        public IActionResult Index()
        {
            return Content("Hello Abp");
        }
    }
}
