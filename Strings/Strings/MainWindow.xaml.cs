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

namespace Strings
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
            char[] charArray = { 'h', 'e', 'l', 'l', 'o' };
            Output("The value of charArray: " + charArray);

            string charString = new String(charArray);
            Output("The value of charString:  " + charString);

            string upper = charString.ToUpper();
            Output("The value of upper:  " + upper);

            string sub = charString.Substring(3, 2);
            Output("The substring value: " + sub);

            charString += ", Newman!";
            Output(charString);
            
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
