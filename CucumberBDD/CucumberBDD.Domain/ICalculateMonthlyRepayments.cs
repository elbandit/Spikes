namespace CucumberBDD.Domain
{
    public interface ICalculateMonthlyRepayments
    {
        decimal CalculateMonthlyRepaymentsFor(LoanRequest loanRequest);
    }
}