using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Expenditure : ControllerBase
    {
        [HttpPost]
        public IActionResult Register()
        {
            return Created();
        }
    }
}
