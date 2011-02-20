namespace CucumberBDD.Domain
{
    public class LoanRequest
    {
        public LoanRequest(int repaymentPeriodInYears, decimal amountRequired, decimal interestRate)
        {
            RepaymentPeriodInYears = repaymentPeriodInYears;
            AmountRequired = amountRequired;
            InterestRate = interestRate;
        }

        public int RepaymentPeriodInYears { get; private set; }
        public decimal AmountRequired { get; private set; }
        public decimal InterestRate { get; private set; }
    }
}