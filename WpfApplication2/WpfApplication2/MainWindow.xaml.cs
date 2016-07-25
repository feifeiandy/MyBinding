using MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vvm;
        public MainWindow()
        {
            InitializeComponent();

            vvm = new ViewModel();
            this.ls.ItemsSource = vvm.stus;
            

            //此处调用多个MVVM的时候将其区分，好处是将命令分类
            this.stcmd.DataContext = vvm;


        }

        #region 传统事件
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.ID = Convert.ToInt32(this.txtID.Text);
            stu.Name = this.txtName.Text;
            this.vvm.add(stu);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.ID = Convert.ToInt32(this.txtID.Text);
            stu.Name = this.txtName.Text;
            this.vvm.delete(stu);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Student stu = new Student();
            stu.ID = Convert.ToInt32(this.txtID.Text);
            stu.Name = this.txtName.Text;
            this.vvm.update(stu);
        } 
        #endregion
    }
}
