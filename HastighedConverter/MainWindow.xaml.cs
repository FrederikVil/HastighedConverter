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
            if (ms.Text == "")
            {
                kmt.Text = "";
            }
            else
            {
                try
                {
                    kmt.Text = (double.Parse(ms.Text) * 3.6).ToString();
                    kmt.CaretIndex = kmt.Text.Length;
                }
                catch (Exception)
                {
                    MessageBox.Show("Input must be a valid number");
                }
                
            }
        }

        private void kmt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (kmt.Text == "")
            {
                ms.Text = "";
            }
            else
            {
                try
                {
                    ms.Text = (double.Parse(kmt.Text) / 3.6).ToString();
                    ms.CaretIndex = ms.Text.Length;
                }
                catch (Exception)
                {
                    MessageBox.Show("Input must be a valid number");
                }
                
            }
        }
    }
}
