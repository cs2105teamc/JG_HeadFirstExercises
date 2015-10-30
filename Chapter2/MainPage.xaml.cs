using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Chapter2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btnMessage_Click(object sender, RoutedEventArgs e)
        {
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;

            tbMyLabel.Text = "name is " + name
                    + "\nx is " + x
                    + "\nd is " + d;

        }

        private void btnifelse_Click(object sender, RoutedEventArgs e)
        {
            int x = 5;
            if (x == 10)
            {
                tbMyLabel.Text = "x must be 10";
            }
            else
            {
                tbMyLabel.Text = "x is not 10";
            }
        }

        private void btnCondition_Click(object sender, RoutedEventArgs e)
        {
            int someValue = 4;
            string name = "Bobbo Jr";
            if ((someValue == 3) && (name == "Joe"))
            {
                tbMyLabel.Text = "x is 3 and name is Joe";            
            }
            tbMyLabel.Text = "this line runs anyway";
        }

        private void btnLoop_Click(object sender, RoutedEventArgs e)
        {
            int count = 0;
            while (count < 10)
            {
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                count++;
            }

            tbMyLabel.Text = "count = " + count;
        }
    }
}
