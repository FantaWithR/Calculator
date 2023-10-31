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

namespace TaschenRechner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int number = 0;
        
        char rechenoperator = ' ';
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "1";
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "2";
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "3";
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "4";
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
           Ergebnis.Text += "5";
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "6";
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "7";
        }
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "8";
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "9";
        }
        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text += "0";
        }
        private void Button_Click_plus(object sender, RoutedEventArgs e)
        {
            number = Convert.ToInt32(Ergebnis.Text);
            Ergebnis.Text = "";
            rechenoperator = '+';
        }
        private void Button_Click_minus(object sender, RoutedEventArgs e)
        {
            number = Convert.ToInt32(Ergebnis.Text);
            rechenoperator = '-';
            Ergebnis.Text = "";
           
        }
        private void Button_Click_multiplizieren(object sender, RoutedEventArgs e)
        {
            number = Convert.ToInt32(Ergebnis.Text);
            Ergebnis.Text = "";
            rechenoperator = '*';
        
        }
        private void Button_Click_dividieren(object sender, RoutedEventArgs e)
        {
            number = Convert.ToInt32(Ergebnis.Text);
            Ergebnis.Text = "";
            rechenoperator= '/';
          
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (rechenoperator)
            {
                case '+': Ergebnis.Text = $"{number + Convert.ToInt32(Ergebnis.Text)}"; break;
                case '-': Ergebnis.Text = $"{number - Convert.ToInt32(Ergebnis.Text)}"; break;
                case '*': Ergebnis.Text = $"{number * Convert.ToInt32(Ergebnis.Text)}"; break;
                case '/': Ergebnis.Text = $"{(double)number / Convert.ToInt32(Ergebnis.Text)}"; break;
                case '&': Ergebnis.Text = $"{(double)Math.Sqrt(number)}"; break; //& soll die Wurz

                default:
                    break;
            }
        }
        private void Reset(object sender, RoutedEventArgs e)
        {
            Ergebnis.Text = "";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            number = Convert.ToInt32(Ergebnis.Text);
            Ergebnis.Text = "";
            rechenoperator = '&';
        }
    }
}
