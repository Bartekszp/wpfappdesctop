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

namespace WpfApp2
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
            int a = int.Parse(bok1.Text);
            int b = int.Parse(bok2.Text);
            int c = int.Parse(bok3.Text);

            double obwod = 0;
            double pole = 0;
            double p = 0;
            string TypTrojkata = "";

            if (a + b <= c || b + c <= a || c + a <= b)
            {
                return;
            }
            if ( a != b && b != c)
            {
                TypTrojkata = "roznoboczny";
            }else if (a == b && b != c)
            {
                TypTrojkata = "rownoramienny";
            }else if(a == b && b == c)
            {
                TypTrojkata = "rownoboczny";
            }

            obwod = a + b + c;
            p = obwod / 2;
            pole = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

            lblWynik.Content = "a = " + a + " b = " + b + " c = " + c + "\n" + "Obwod wynosi: " + obwod + "\n" + "Pole Wynosi: " + Math.Round(pole,2) + "\n" + "Trojkat jest: " + TypTrojkata; 
        }
    }
}
