using Microsoft.AspNetCore.Antiforgery;
using Abp.BG.Controllers;

namespace Abp.BG.Web.Host.Controllers
{
    public class AntiForgeryController : BGControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
