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
            this.DataContext = vvm;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.vvm.Add(Convert.ToInt32(this.txtID.Text), this.txtName.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.vvm.dele(Convert.ToInt32(this.txtID.Text));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.vvm.update(Convert.ToInt32(this.txtID.Text), this.txtName.Text);
        }
    }
}
