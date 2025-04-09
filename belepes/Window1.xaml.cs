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
using System.Windows.Shapes;

namespace belepes
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public string felhasznalo_nev = "info";
        public string jelszo = "Premo900";
        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("felhasználó név:info, jelszó:Premo900");
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            string beirtnev = textbox.Text;
            string beirtjelszo = password.Password;

            
            if (beirtnev == felhasznalo_nev && beirtjelszo == jelszo)
            {
               
                Window3 adatok = new Window3();
                adatok.Show();
                this.Close(); 
            }
            else
            {
                
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }
        }
    }
}
