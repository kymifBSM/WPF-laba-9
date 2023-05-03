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
    /// Логика взаимодействия для zadanie3.xaml
    /// </summary>
    public partial class zadanie3 : Window
    {
        public zadanie3()
        {
            InitializeComponent();
        }

        private string bin;
        private string oct;
        private void Binary(object sender, RoutedEventArgs e)
        {
            bin = Convert.ToString(int.Parse(digit.Text), 2);
        }

        private void Octagonal(object sender, RoutedEventArgs e)
        {
            oct = Convert.ToString(int.Parse(digit.Text), 8);
        }


        private void Calculate(object sender, RoutedEventArgs e)
        {
            if (oct == null && bin != null) { res.Text = bin; }
            else if (oct != null) { res.Text = oct; }
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            if (oct == null && bin != null) { binary.IsChecked = false; }
            else if (oct != null) { octagonal.IsChecked = false; }
            res.Text = null;
            bin = null;
            oct = null;
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
        public void Back(Object sender, RoutedEventArgs e)
        {
            zadanie2 z2 = new zadanie2();
            z2.Show();
            Close();
        }
    }
}
