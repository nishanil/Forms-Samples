using Demo.Core.Services;
using Demo.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechEdDemo.Views
{
    public partial class CalculatorView
    {
        CalculatorViewModel viewModel;
        public CalculatorView()
        {
            InitializeComponent();

            BindingContext = viewModel = new CalculatorViewModel(new CalculationService());
            viewModel.CurrentPage = this;
        }
    }
}
