using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1
{
    public class MyCommandBase : ICommand
    {
        // Have virtual methods here. Actual Implementation will be done in the platform specific codes 
        public virtual bool CanExecute(object parameter)
        { 
            return true;
        }

        public virtual event EventHandler CanExecuteChanged;

        public virtual void Execute(object parameter)
        {
            
        }
    }
}
