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

namespace DatesAndTimes
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
            DateTime dt = new DateTime(2018, 01, 04);

            //Output("Date:  " + dt.ToString("M/d/yyyy"));
            //Output("Date:  " + dt.ToString("MMMM d, yyyy"));

            DateTime now = DateTime.Now;
            Output("Now:  " + now);

            DateTime anotherDay = dt.AddDays(-1);
            Output("AnotherDay:  " + anotherDay);

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
