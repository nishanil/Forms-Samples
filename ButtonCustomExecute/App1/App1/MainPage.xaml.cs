using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.BindingContext = new MainPageViewModel();
           
        }
    }
}
