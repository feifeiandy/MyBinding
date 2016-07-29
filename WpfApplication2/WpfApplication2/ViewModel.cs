using MVVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApplication2
{
    public class ViewModel
    {
        public ObservableCollection<Student> stus { get; set; }
        public MyCommad Mcomd { get; set; }
        public MyCommad Mcomd2 { get; set; }
        public MyCommad Mcomd3 { get; set; }
        public MyCommad Mcomd4 { get; set; }
        public ViewModel()
        {
            this.stus = new ObservableCollection<Student>() { 
            new Student(){ ID=1, Name="张三"},
            new Student(){ ID=2, Name="李四"}
            };
            this.Mcomd = new MyCommad(add);
            this.Mcomd2 = new MyCommad(delete);
            this.Mcomd4 = new MyCommad(deleteint);
            this.Mcomd3 = new MyCommad(update);
        }
        #region 属于DAL层的增，删，改 
        //如果一下的方法给传统事件调用为public ,如果只给命令调用则为private
        public void add(Student stu)
        {
            //ps：此处必须new个新的实例，防止引用到同一个实例对象上，这与前台写法有关
            //<StackPanel.DataContext>
            //    <loacl:Student ID="3" Name="ces"></loacl:Student>
            //</StackPanel.DataContext>
            Student stutemp = new Student();
            stutemp.ID = stu.ID;
            stutemp.Name = stu.Name;
            this.stus.Add(stutemp);
        }
        public void delete(Student stu)
        {
            Student stutemp = this.stus.First(x => x.ID == stu.ID);
            //删除的时候必须先查到对象实例在集合中的引用，这样才能删除
            //直接删除一个实例但是不在集合中是无效的，如下
            //Student stutemp = new Student();
            //stutemp.ID = stu.ID;
            //stutemp.Name = stu.Name;
            //this.stus.Remove(stutemp);
            this.stus.Remove(stutemp);
        }
        public void deleteint(int id)
        {
            this.stus.RemoveAt(id - 1);
        }
        public void update(Student stu)
        {
            this.stus.First(x => x.ID == stu.ID).Name = stu.Name;
        } 
        #endregion
    }
}
