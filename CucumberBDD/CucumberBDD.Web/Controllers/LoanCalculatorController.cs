using System.Web.Mvc;
using CucumberBDD.Domain;
using CucumberBDD.Web.Models;

namespace CucumberBDD.Web.Controllers
{
    public class LoanCalculatorController : Controller
    {
        private readonly ICalculateMonthlyRepayments _repaymentCalculator;

        public LoanCalculatorController() : this (new MonthlyRepaymentCalculator())
        {           }

        public LoanCalculatorController(ICalculateMonthlyRepayments repaymentCalculator)
        {
            _repaymentCalculator = repaymentCalculator;
        }

        //
        // GET: /LoanCalculator/

        public ActionResult Index()
        {
            var viewModel = new LoanRepaymentQueryViewModel();
            viewModel.Title = "Loan Repayment Calculator";

            return View(viewModel);
        }

        //
        // POST: /LoanCalculator/

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(LoanRepaymentQueryViewModel loanRepaymentQueryViewModel)
        {
            var loanRequest = new LoanRequest(loanRepaymentQueryViewModel.RepaymentTerm, 
                                              loanRepaymentQueryViewModel.LoanAmount,                
                                              loanRepaymentQueryViewModel.InterestRate);

            loanRepaymentQueryViewModel.MonthlyRepaymentAmount =
                _repaymentCalculator.CalculateMonthlyRepaymentsFor(loanRequest).ToString();
            return View(loanRepaymentQueryViewModel);
        }
    }
}
