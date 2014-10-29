using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Demo.Core.Services;
using TechEdDemo;
using Xamarin.Forms;
using TechEdDemo.Views;

namespace Demo.Core.ViewModels
{
    public class CalculatorViewModel : BaseViewModel
    {
        private readonly ICalculationService _calculationService;

        public CalculatorViewModel(ICalculationService calculationService)
        {
            _calculationService = calculationService;
            LoanAmount = 10000;
            MonthlyInstallment = 1000;
            InterestRate = 4;
        }

        private long _loanAmount;
        public long LoanAmount
        {
            get { return _loanAmount; }
            set { _loanAmount = value; RaisePropertyChanged(); }
        }

        private long _monthlyInstallment;
        public long MonthlyInstallment
        {
            get { return _monthlyInstallment; }
            set { _monthlyInstallment = value; RaisePropertyChanged();  }
        }

        private double _interestRate;
        public double InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; RaisePropertyChanged(); }
        }

        private double _loanRepaymentPeriod;
        public double LoanRepaymentPeriod
        {
            get { return _loanRepaymentPeriod; }
            private set { _loanRepaymentPeriod = value; RaisePropertyChanged(); }
        }

        private void Calculate()
        {
            LoanRepaymentPeriod = _calculationService.CalculateInterest(InterestRate, LoanAmount, MonthlyInstallment);

            var resultViewModel = new CalculatorResultViewModel(_loanAmount, _monthlyInstallment, (long)_interestRate, _loanRepaymentPeriod);
            var resultView = new CalculatorResultView(resultViewModel);
            CurrentPage.Navigation.PushModalAsync(resultView);
            //ShowViewModel<CalculatorResultViewModel>(new 
            //{
            //    loanAmount = _loanAmount,
            //    interestRate = _interestRate,
            //    monthlyInstallment = _monthlyInstallment,
            //    loanRepaymentPeriod = _loanRepaymentPeriod
            //});

        }


        //ShowViewModel<CalculatorResultViewModel>(new { calculator = this });

        private ICommand _calculateCommand;
        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new Command(Calculate);
                return _calculateCommand;
            }
        }

        private ICommand _resetCommand;
        public ICommand ResetCommand
        {
            get
            {
                _resetCommand = _resetCommand ?? new Command(() =>
                {
                    LoanAmount = 0;
                    InterestRate = 0;
                    MonthlyInstallment = 0;
                });
                return _resetCommand;
            }
        }
        
    }
}
