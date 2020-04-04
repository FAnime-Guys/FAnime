using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AnimeLister.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Echo([FromQuery] string message)
        {
            if (string.IsNullOrEmpty(message)) message = "I can't hear you!";

            return await Task.FromResult(Ok(message));
        }
    }
}