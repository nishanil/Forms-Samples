using App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1;
using System.Windows;
using Android.Widget;

[assembly: Dependency(typeof(MyCommand))]
namespace App1
{
    public class MyCommand : MyCommandBase
    {

        public override void Execute(object parameter)
        {
            Toast.MakeText(Forms.Context, "Hey! from Android", ToastLength.Long).Show();
        }
    }
}
