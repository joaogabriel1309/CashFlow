using CashFlow.Application.UserCase.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class Expenditure : ControllerBase
    {
        [HttpPost]
        public IActionResult Register([FromBody] RequestRegisterExpensesJson request)
        {
            try
            {
                var userCase = new RegisterExpensesUseCase();
                var response = userCase.Execute(request);
                return Created(string.Empty, response);
            }
            catch (ArgumentException ex)
            {
                var errorReponser = new ResponseErrorJson
                {
                    ErrorMessage = ex.Message
                };
                return BadRequest(errorReponser);
            }
            catch
            {
                var errorReponser = new ResponseErrorJson
                {
                    ErrorMessage = "unknown error"
                };
                return StatusCode(StatusCodes.Status500InternalServerError, errorReponser);
            }
        }
    }
}
