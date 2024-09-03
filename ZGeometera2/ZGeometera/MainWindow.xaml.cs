using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ZGeometera
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
            int a = int.Parse(text1.Text);
            int b = int.Parse(text2.Text);
            int index = ComboBox.SelectedIndex;

            if (a == b) 
            {
                label1.Content = "To jest kwadrat";
            }else
            {
                label1.Content = "To jest prostokat";
            }
            
            if (index == 0)
            {
                label2.Content = "Obwod wynosi: "+ a * b;
            }else if (index == 1)
            {

            }else if(index == 2) 
            {
                
            }

        }
    }
}
