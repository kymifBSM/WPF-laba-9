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

namespace WPF_laba9
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Addition(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) + double.Parse(second.Text)).ToString();
        }

        private void Subtraction(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) - double.Parse(second.Text)).ToString();
        }

        private void Multiplication(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) * double.Parse(second.Text)).ToString();
        }

        private void Division(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text) / double.Parse(second.Text)).ToString();
        }
        private void Exponentiation(object sender, RoutedEventArgs e)
        {
            result.Text = Math.Pow(double.Parse(first.Text), double.Parse(second.Text)).ToString();
        }
        private void Remainder(object sender, RoutedEventArgs e)
        {
            result.Text = (double.Parse(first.Text)% double.Parse(second.Text)).ToString();
        }

        private void Zadanie2(object sender, RoutedEventArgs e)
        {
            zadanie2 z2 = new zadanie2();
            z2.Show();
            Close();
        }
    }
}
