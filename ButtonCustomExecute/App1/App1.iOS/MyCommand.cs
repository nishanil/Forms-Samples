using App1;
using App1.WinPhone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1;
using System.Windows;
using MonoTouch.UIKit;

[assembly: Dependency(typeof(MyCommand))]
namespace App1.WinPhone
{
    public class MyCommand : MyCommandBase
    {

        public override void Execute(object parameter)
        {
            new UIAlertView("Hey!", "Hello from iOS", null, "OK").Show();
        }
    }
}
