using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;

namespace CashFlow.Infrastructure.DataAccess.Repositories
{
    internal class ExpensesReporitory : IExpensesRepository
    {
        private readonly CashFlowDbContext _dbContext;
        public ExpensesReporitory(CashFlowDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Expense expense)
        {
            _dbContext.Expenses.Add(expense);

            _dbContext.SaveChanges();
        }
    }
}
