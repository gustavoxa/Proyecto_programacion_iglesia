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
using Capadenegocios;

namespace Iglesiaform
{
    /// <summary>
    /// Lógica de interacción para segundomodo.xaml
    /// </summary>
    public partial class frmCatequizado : Window
    {
        
        private int cont = 0;
        private int cont1 = 0;
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
            bool? Bautismo = cbInBautismo.IsChecked;
            bool? Primerocomunion = cbInPrimeraComunion.IsChecked;
            bool? Primeroconfirmacion = cbInPrimeraConfirmacion.IsChecked;
            bool? Comunion = cbInSegundoComunion.IsChecked;
            if ((bool)Bautismo) {
                cont1++;
            }
            if ((bool)Primerocomunion) {
                cont1++;
            }
            if ((bool)Primeroconfirmacion) {
                cont1++;
            }
            if ((bool)Comunion) {
                cont1++;
            }
            if (cont == cont1) { 
            
            }
            
            prueba.Text = "hola";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (cbInBautismo.IsVisible)
            {
                cont++;
            }
            if (cbInPrimeraComunion.IsVisible)
            { 
                cont++;
            }
            if (cbInPrimeraConfirmacion.IsVisible)
            {
                cont++;
            }
            if (cbInSegundoComunion.IsVisible)
            {
                cont++;
            }
            txtInCedulaCz.MaxLength = 10;
            txtInCeluCz.MaxLength = 10;
            txtInTelefCz.MaxLength = 10;
            txtInTelefEmergCz.MaxLength = 10;
            txtInCeluEmergCz.MaxLength = 10;
            txtInComuniCz.IsReadOnly = true;
            txtInParentCz.IsReadOnly = true;
            txtInViveOtro.IsReadOnly = true;
        }

        private void rbnInViveO_Click(object sender, RoutedEventArgs e)
        {
            txtInViveOtro.IsReadOnly = false;
        }
        private void rbnInVive1_Click(object sender, RoutedEventArgs e)
        {
            txtInViveOtro.IsReadOnly = true;
        }
        private void rbnInVive2_Click(object sender, RoutedEventArgs e)
        {
            txtInComuniCz.IsReadOnly = false;
            txtInParentCz.IsReadOnly = false;
        }
        private void rbnInVive3_Click(object sender, RoutedEventArgs e)
        {
            txtInComuniCz.IsReadOnly = true;
            txtInParentCz.IsReadOnly = true;
        }
    }
}

