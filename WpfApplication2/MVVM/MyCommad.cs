using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM
{
    public class MyCommad : ICommand
    {
        private Action<Student> _execute;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this._execute(parameter as Student);
        }

        public MyCommad(Action<Student> execute)
        {
            this._execute = execute;
        }
    }
}
