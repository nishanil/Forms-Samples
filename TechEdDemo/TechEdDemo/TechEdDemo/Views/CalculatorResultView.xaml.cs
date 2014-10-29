using Demo.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEdDemo.Views
{
    public partial class CalculatorResultView
    {
        //TODO: change to IViewModel
        public CalculatorResultView(CalculatorResultViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel.LoanDetail;
        }
    }
}
