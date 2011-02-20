using System;

namespace CucumberBDD.Domain
{
    public class MonthlyRepaymentCalculator : ICalculateMonthlyRepayments
    {
        public decimal CalculateMonthlyRepaymentsFor(LoanRequest loanRequest)
        {
            var loanAmount = (double)(loanRequest.AmountRequired);

            var rate = (double)(loanRequest.InterestRate / 100);

            var paymentVal = ((loanAmount * rate) / 12) * (1 / (1 - Math.Pow((1 / (1 + rate)), loanRequest.RepaymentPeriodInYears)));

            return decimal.Round((decimal)paymentVal, 2);
        }
    }
}