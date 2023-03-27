using System;
using System.Collections.Generic;
using System.Data.Common;
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

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Receiver calculator = new Receiver();

        Output2 output2 = new Output2();

        //TextBlock output1 = (TextBlock)GridOutput.
        //        Children.
        //        Cast<UIElement>().
        //        First(e => Grid.GetRow(e) == 0 && Grid.GetColumn(e) == 0);
        //TextBlock output2 = (TextBlock)GridOutput.
        //        Children.
        //        Cast<UIElement>().
        //        First(e => Grid.GetRow(e) == 1 && Grid.GetColumn(e) == 0);

        public MainWindow()
        {
            output2.TextOutput2 = "1223";
            InitializeComponent();
        }

        private void AdditionPanel_Click(object sender, RoutedEventArgs e)
        {
            AdditPanel.ShowHidePanel(this);
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            output2.TextOutput2 += "1";
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void C_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteLast_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Are_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ZeroDouble_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pi_Click(object sender, RoutedEventArgs e)
        {

        }

        private void E_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SquareRoot_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Power_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Ln_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
