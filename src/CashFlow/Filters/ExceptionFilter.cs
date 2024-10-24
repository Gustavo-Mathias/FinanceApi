using Microsoft.AspNetCore.Mvc.Filters;

namespace CashFlow.Api.Filters;

public class ExceptionFilter : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    { 
        
    }

    private void HandleProjectExcept(ExceptionContext context)
    {

    }
    private void ThrowUnkowError (ExceptionContext context)
    {

    } 

}
