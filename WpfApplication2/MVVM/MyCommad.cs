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
        private Action<int> _executeint;
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            //此处需要知道不同方法需要的参数类型

            if (parameter is Student)
            {
                this._execute(parameter as Student);
            }
            else if (parameter is string)
            {
                this._executeint(Convert.ToInt32(parameter));
            }
        }

        public MyCommad(Action<Student> execute)
        {
            this._execute = execute;
        }
        public MyCommad(Action<int> execute)
        {
            this._executeint = execute;
        }
    }
}
