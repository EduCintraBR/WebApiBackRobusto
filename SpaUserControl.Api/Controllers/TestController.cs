using System.Web.Http;

namespace SpaUserControl.Api.Controllers
{
    public class TestController : ApiController
    {
        [Authorize]
        public string Get()
        {
            return User.Identity.Name;
        }
    }
}
