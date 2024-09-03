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

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxImie.Text == "" || txtBoxNazwisko.Text == "")
            {
                MessageBox.Show("Wprowadź dane");
                return;
            }
            string oczy = "";
            if (RadButNieb.IsChecked == true)
            {
                oczy = "niebieskie";
            }else if (RadButPiwn.IsChecked == true)
            {

                oczy = "piwne";
            }
            else if (RadButZiel.IsChecked == true)
            {
                oczy = "zielone";
            }
            MessageBox.Show($"{txtBoxImie.Text} {txtBoxNazwisko.Text} kolor oczu {oczy}");
        }

        private void lostFucusNumer(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse(txtBoxNumer.Text, out int res))
            {
                return;
            }

            //MessageBox.Show($"assets/{txtBoxNumer.Text}-zdjecie.png");
            imgPer.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri($"assets/{txtBoxNumer.Text}-zdjecie.jpg", UriKind.Relative));
            ImgPal.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri($"assets/{txtBoxNumer.Text}-odcisk.jpg", UriKind.Relative));

        }
    }
}
