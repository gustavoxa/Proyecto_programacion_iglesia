using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
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

namespace Iglesiaform
{
    /// <summary>
    /// Lógica de interacción para segundomodo.xaml
    /// </summary>
    public partial class frmCatequizado : Window
    {
        private int cont = 0;
        public frmCatequizado()
        {
            InitializeComponent();
            
        }
        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            menuiglesia form1 = new menuiglesia();
            this.Visibility = Visibility.Hidden;
            form1.ShowDialog();
            this.Close();
        }
        
        private void boton1_Click(object sender, RoutedEventArgs e) 
        {
           
           
 
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (cbInPrimeraComunion.IsVisible)
            {
                cont++;
            }

        }
    }
}
