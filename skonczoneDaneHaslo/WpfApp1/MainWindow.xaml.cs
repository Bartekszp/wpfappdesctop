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
        string haslo = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = txtBoxImie.Text;
            string nazwisko = txtBoxNazwiko.Text;
            string wybor = ComBox.Text;
            if (imie == "" && nazwisko == "" && wybor == "")
            {
                MessageBox.Show("Uzupelnij dane");
                return;
            }
            

            MessageBox.Show($"Dane pracownika: {imie} {nazwisko} {wybor} haslo: {haslo}");
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string male = "qwertyuiopasdfghjklzxcvbnm";
            string duze = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string liczby = "1234567890";
            string znaki = "!@#$%^&*()_+-=";
            haslo = "";
            int iloscZnakow;
            if (int.TryParse(IloscZnakowlbl.Text, out iloscZnakow) == false)
            {
                MessageBox.Show("Podaj ilosc znakow");
                return;
            }


            
            Random rnd = new Random();

            for (int i = 0; i < iloscZnakow; i++)
            {
                if (i == 0) haslo += male[rnd.Next(male.Length)];
                else if(i == 1 && WielkieChecBox.IsChecked == true) haslo += duze[rnd.Next(duze.Length)];
                else if(i == 2 && CyfryChecBox.IsChecked == true) haslo += liczby[rnd.Next(liczby.Length)];
                else if(i == 3 && ZnakiChecBox.IsChecked == true) haslo += znaki[rnd.Next(znaki.Length)];
                else haslo += male[rnd.Next(male.Length)];
            }

            MessageBox.Show(haslo);


        }

        private void WielkieChecBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
