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

namespace Variables
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
            int i = 42;
            Output("The value is " + i);

            int meaningOfLife = new int();
            Output("The value is " + meaningOfLife);

            var implicitValue = 56L;
            Output("The value is " + implicitValue);
            Output("The variable's implicit value is " + implicitValue.GetType().ToString());

            byte byteValue = 255;
            Output("The byte value is " + byteValue);

            byteValue++;
            Output("The value is " + byteValue);


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
