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

namespace Pole_kwadratu
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

        private void ObliczClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtBok.Text, out double bok))
            {
                double obwod = 4 * bok;
                double pole = bok * bok;

                txtObwod.Text = obwod.ToString();
                txtPole.Text = pole.ToString();
            }
            else
            {
                MessageBox.Show("Podaj prawidłową liczbę jako długość boku.");
            }
        }

        private void WyczyscClick(object sender, RoutedEventArgs e)
        {
            txtBok.Clear();
            txtPole.Clear();
            txtObwod.Clear();
        }
    }
}