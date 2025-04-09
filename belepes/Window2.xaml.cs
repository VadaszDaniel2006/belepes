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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string ujfelhsznalo = textbox2.Text;
            string ujjelszo = password2.Password;



            if (ujfelhsznalo == textbox2.Text && ujjelszo == password2.Password)
            {


                MessageBox.Show("Fiók létrehozva! Most bejelentkezhetsz.");


                this.Close();
            }

        
        }    }
}
