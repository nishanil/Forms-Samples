using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Services
{
    public class CalculationService:ICalculationService
    {
        public double CalculateInterest(double interestRate, long loanAmount, long monthlyInstalmentAmount)
        {
            
            var result_0 = interestRate / 1200;
            var result_1 = Math.Log(1 + result_0);
            var result_2 = loanAmount * result_0;
            var result_3 = result_2 / monthlyInstalmentAmount;
            var result_4 = 1 - result_3;
            var result_5 = Math.Log(result_4);
            var result_6 = result_5 / result_1;
            var result_7 = Math.Round(result_6) * (-1);
            result_7 = result_7 / 12;
            result_7 = Math.Round(result_7 * 10);
            
            double loanRepaymentPeriodInYears = result_7 / 10;
            return loanRepaymentPeriodInYears;
        }
    }
}
