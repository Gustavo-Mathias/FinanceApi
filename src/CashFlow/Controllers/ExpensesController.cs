using CashFlow.Aplication.UseCases.Expenses.Register;
using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    [HttpPost]

    public IActionResult Register([FromBody] RequestRegisterExpenseJson request)
    {
        try
        {
            var useCase = new RegisterExpenseUseCase();

            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch(ErrorOnValidationException ex)
        {
            var errorResponse = new ResponseErrorJson(ex.Errors); 

            return BadRequest(errorResponse);
        }
        catch(DivideByZeroException ex)
        {
            var errorResponse = new ResponseErrorJson("Unknown error");    

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
