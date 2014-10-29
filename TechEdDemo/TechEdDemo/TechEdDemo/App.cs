using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechEdDemo.Views;
using Xamarin.Forms;

namespace TechEdDemo
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new CalculatorView();
        }
    }
}
