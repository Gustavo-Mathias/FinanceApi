using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;
using CashFlow.Domain.Entities;
using CashFlow.Exception.ExceptionsBase;
using CashFlow.Infrastructure.DataAccess;

namespace CashFlow.Aplication.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ReponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        Validate(request);

         var dbContext = new CashFlowDbContext();

        var entity = new Expense
        {
            Amount = request.Amount,
            Date = request.Date,
            Description = request.Description,
            Title = request.Title,
            PaymentType = (decimal)(CashFlow.Domain.Entities.Enums.PaymentType)request.PaymentType,
        };
        
        dbContext.Expenses.Add(entity);

        dbContext.SaveChanges();

        return new ReponseRegisteredExpenseJson();
    }

    private void Validate(RequestRegisterExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();
         
        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }
    }
}