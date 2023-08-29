using Microsoft.AspNetCore.Mvc;

namespace testapiapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {

        public string Get()
        {
            return "hello world success";
        }
    }
}