using CashFlow.Communication.Reponses;
using CashFlow.Communication.Requests;

namespace CashFlow.Aplication.UseCases.Expenses.Register;
public class RegisterExpenseUseCase
{
    public ReponseRegisteredExpenseJson Execute(RequestRegisterExpenseJson request)
    {
        return new ReponseRegisteredExpenseJson();
    }
}
