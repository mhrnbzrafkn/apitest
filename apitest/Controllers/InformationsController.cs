using Microsoft.AspNetCore.Mvc;

namespace apitest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InformationsController : ControllerBase
    {
        [HttpGet]
        public string GetInformations()
        {
            return "some informations...";
        }
    }
}