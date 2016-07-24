using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public class Student : INotifyPropertyChanged
    {
        int id;


        public int ID
        {
            get { return id; }
            set
            {
                id = value;
                this.setv("ID");
            }
        }
        string name;

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                this.setv("Name");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void setv(string name)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
