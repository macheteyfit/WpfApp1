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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int count;
        private void ButtonClick1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You clicked my Button", "My Title1", MessageBoxButton.OK);
        }
        private void ButtonClick2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Why you clicked my Button", "My Title2", MessageBoxButton.OK);
        }
        private void ButtonClick3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Переделывай", "My Title3", MessageBoxButton.OK);
        }
        private void addCount(object sender, RoutedEventArgs e)
        {
            count++;
            myTextBlock.Text = $"count {count}";
           
        }
        public MainWindow()
        {        
            InitializeComponent();
            MyButton1.Click += ButtonClick1;
            MyButton2.Click += ButtonClick2;
            MyButton3.Click += ButtonClick3;
            MyButton4.Click += addCount;



        }
    }
}
