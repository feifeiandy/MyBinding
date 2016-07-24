using MVVM;
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
        public ObservableCollection<Student> stus { get; set; }
        public MyCommad Mcomd { get; set; }
        public ViewModel()
        {
            this.stus = new ObservableCollection<Student>() { 
            new Student(){ ID=1, Name="张三"},
            new Student(){ ID=2, Name="李四"}
            
            };

            this.Mcomd = new MyCommad(add);
        }

        private void add(Student stu)
        {
            this.stus.Add(stu);
        }

        public void Add(int id, string name)
        {
            Student stu = new Student() { ID = id, Name = name };
            this.stus.Add(stu);
        }

        public void dele(int id)
        {
            this.stus.RemoveAt(id - 1);
        }

        public void update(int id, string name)
        {
            this.stus.First(x => x.ID == id).Name = name;
        }

    }

    
}
