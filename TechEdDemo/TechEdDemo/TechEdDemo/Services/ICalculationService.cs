using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Services
{
    public interface ICalculationService
    {
        double CalculateInterest(double interestRate, long loanAmount, long monthlyInstalmentAmount);
    }
}
