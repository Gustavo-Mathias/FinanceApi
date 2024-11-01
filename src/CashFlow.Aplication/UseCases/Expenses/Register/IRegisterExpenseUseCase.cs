using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;

namespace CashFlow.Aplication.UseCases.Expenses.Register
{
    public interface IRegisterExpenseUseCase
    {
        ReponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request);
    }
}
