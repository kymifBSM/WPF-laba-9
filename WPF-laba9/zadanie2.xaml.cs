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
using System.Windows.Shapes;

namespace WPF_laba9
{
    /// <summary>
    /// Логика взаимодействия для zadanie2.xaml
    /// </summary>
    public partial class zadanie2 : Window
    {
        public zadanie2()
        {
            InitializeComponent();
        }
        public void rColor(Object sender, RoutedEventArgs e)
        {
            red.Background = Brushes.Red;
            yellow.Background = Brushes.Black;
            green.Background = Brushes.Black;

        }

        public void yColor(Object sender, RoutedEventArgs e)
        {
            red.Background = Brushes.Black;
            yellow.Background = Brushes.Yellow;
            green.Background = Brushes.Black;
        }

        public void gColor(Object sender, RoutedEventArgs e)
        {
            red.Background = Brushes.Black;
            yellow.Background = Brushes.Black;
            green.Background = Brushes.Lime;
        }
        public void aColor(Object sender, RoutedEventArgs e)
        {
            red.Background = Brushes.Red;
            yellow.Background = Brushes.Yellow;
            green.Background = Brushes.Lime;
        }

        public void GO(Object sender, RoutedEventArgs e)
        {
            zadanie3 z3 = new zadanie3();
            z3.Show();
            Close();
        }

        public void Back(Object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            Close();
        }
    }
}
