using System.Windows.Input;

using Demo.Core.Services;
using TechEdDemo;

namespace Demo.Core.ViewModels
{
    public class CalculatorResultViewModel : BaseViewModel
    {
        public CalculatorResultViewModel(long loanAmount, long monthlyInstallment, long interestRate, double loanRepaymentPeriod)
        {
            LoanDetail = new LoanDetail
            {
                LoanAmount = loanAmount, MonthlyInstallment = monthlyInstallment, InterestRate = interestRate,
                LoanRepaymentPeriod = string.Format("{0} years",loanRepaymentPeriod)
            };
        }

        public LoanDetail LoanDetail { get; set; }
    }

    public class LoanDetail
    {
        public long LoanAmount { get; set; }

        public long MonthlyInstallment
        {
            get;
            set;
        }

       
        public double InterestRate
        {
            get;
            set;
        }

       
        public string LoanRepaymentPeriod
        {
            get;
            set;
        }
    }
}
