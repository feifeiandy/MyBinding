using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class ViewModel
    {
        public ObservableCollection<Student> stus;
        public ViewModel()
        {
            this.stus = new ObservableCollection<Student>() { 
            new Student(){ ID=1, Name="张三"},
            new Student(){ ID=2, Name="李四"}
            
            };
        }

        public void Add(int id,string name)
        {
            Student stu = new Student() {ID=id,Name=name };
            this.stus.Add(stu);
        }

        public void dele(int id)
        {
            this.stus.RemoveAt(id-1);
        }

        public void update(int id,string name)
        {
            this.stus.First(x => x.ID == id).Name = name;
        }
       
    }

    public class Student:INotifyPropertyChanged
    {
        int id;

        public int ID
        {
            get { return id; }
            set { id = value;
            this.setv("ID");
            }
        }
        string name;

        public string Name
        {
            get { return name; }
            set { name = value;
            this.setv("Name");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void setv(string name)
        {
            if (this.PropertyChanged!=null)
            {
                this.PropertyChanged.Invoke(this,new PropertyChangedEventArgs(name));
            }
        }
    }
}
