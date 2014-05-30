
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public class MainPageViewModel : ViewModelBase
    {
        public MyCommandBase MyCommand { get; set; }

        public MainPageViewModel()
        {
            MyCommand = Xamarin.Forms.DependencyService.Get<MyCommandBase>(DependencyFetchTarget.NewInstance);
            
        }

    }
}
