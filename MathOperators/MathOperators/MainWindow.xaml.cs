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

namespace MathOperators
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Run(object sender, RoutedEventArgs e)
        {
            double value1 = 42;
            double value2 = 12;

            Output("Value1:  " + value1);
            Output("Value2:  " + value2);

            Output("Add:  " + (value1 + value2));
            Output("Subtract:  " + (value1 - value2));
            Output("Multiply:  " + (value1 * value2));
            Output("Divide:  " + (value1 / value2));
            Output("Modulo:  " + (value1 % value2));

            value1++;
            Output("v1 Incremented:  " + value1);

            value2--;
            Output("v2 Decremented:  " + value2);
        }

        private void Output(string value)
        {
            txtOutput.Text += value + Environment.NewLine;
        }

        private void ClearOutput(object sender, RoutedEventArgs e)
        {
            txtOutput.Text = "";
            txtInput.Text = "";
        }

    }
}
