using System.Web.Http;

namespace Api.Controllers
{
    public class HelpController:ApiController
    {

        [HttpGet, Route("")]
        public IHttpActionResult Ping()
        {
            return Ok("Pong!");
        }
    }
}
