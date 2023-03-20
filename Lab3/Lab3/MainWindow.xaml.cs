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

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static bool IsShowAddPanel = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AdditionPanel_Click(object sender, RoutedEventArgs e)
        {
            GridCalcButtons.ColumnDefinitions[4].Width = new GridLength(IsShowAddPanel ? 1 : 0, GridUnitType.Star);
            IsShowAddPanel = !IsShowAddPanel;
        }
    }
}
