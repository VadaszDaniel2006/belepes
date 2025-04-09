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
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(texbox1.Text); 
            string nev = textbox2.Text;      
            int atlag = int.Parse(textbox3.Text); 


            tanulo ujTanulo = new tanulo(id, nev, atlag);

            
            Tanulok.Add(ujTanulo);
        }
    }
}
