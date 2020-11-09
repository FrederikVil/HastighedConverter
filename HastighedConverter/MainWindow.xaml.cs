using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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

namespace HastighedConverter
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

        private void ms_TextChanged(object sender, TextChangedEventArgs e)
        {
            double x = double.Parse(ms.Text);
            if (ms.Text == "")
            {
                kmt.Text = "";
            }
            else
            {
                x = x * 3.6;
                kmt.Text = Math.Round(x, 2).ToString();
            }
        }

        private void kmt_TextChanged(object sender, TextChangedEventArgs e)
        {
            double x = double.Parse(kmt.Text);
            if (kmt.Text == "")
            {
                ms.Text = "";
            }
            else
            {
                x = x / 3.6;
                ms.Text = Math.Round(x, 2).ToString();
            }
        }
    }
}
