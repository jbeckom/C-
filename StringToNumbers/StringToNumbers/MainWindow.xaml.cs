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

namespace StringToNumbers
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
            string s = "255";
            int intFromString = Int32.Parse(s);
            Output("intFromString:  " + intFromString);

            int ifsDoubled = intFromString * 2;
            Output("ifsDoubled:  " + ifsDoubled);

            string s2 = "19.99xxx";
            //double doubleFromString = Double.Parse(s2);
            //Output("doubleFromString:  " + doubleFromString);

            //int dfsDoubled = doubleFromString * 2;
            //Output("dfsDoubled:  " + dfsDoubled);

            double doubleFromString;
            if (Double.TryParse(s2, out doubleFromString))
            {
                Output("doubleFromString:  " + doubleFromString);
            }
            else
            {
                Output("Couldn't parse value.");
            }


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
