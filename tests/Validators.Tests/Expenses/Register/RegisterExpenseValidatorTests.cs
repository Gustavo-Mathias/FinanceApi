using CashFlow.Communication.Requests;

namespace Validators.Tests.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Sucess()
    {
        //Arrange
        var validator = new RegisterExpenseValidatorTests();
        var request = new RequestRegisterExpenseJson
        {
            Amount = 100,
            Date = DateTime.Now.AddDays(-1),
            Description = "Description",
            Title = "Apple",
            PaymentType = CashFlow.Communication.Enums.PaymentType.CreditCard
        };
        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);
    }

    private object Validate(RequestRegisterExpenseJson request)
    {
        throw new NotImplementedException();
    }
}
