namespace CucumberBDD.Web.Models
{
    public class LoanRepaymentQueryViewModel
    {
        public string Title { get; set; }
        public int RepaymentTerm { get; set; }
        public decimal LoanAmount { get; set; }
        public string MonthlyRepaymentAmount { get; set; }
        public decimal InterestRate { get; set; }        
    }
}