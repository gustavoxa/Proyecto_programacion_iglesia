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

namespace Iglesiaform
{
    /// <summary>
    /// Lógica de interacción para menuiglesia.xaml
    /// </summary>
    public partial class menuiglesia : Window
    {
        public menuiglesia()
        {
            InitializeComponent();
        }
        private void Confirmacion_Click(object sender, RoutedEventArgs e)
        {
            frmCatequizado catequizado = new frmCatequizado();
            // Segundo Confirmación
            catequizado.tbdSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizado.cbInSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizado.tbpSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizado.txtInPconfirmacionS.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Hidden;
            catequizado.ShowDialog();
            this.Close();
        }
        private void Talleres_Click(object sender, RoutedEventArgs e)
        {
            frmEstudiante estudiante = new frmEstudiante();
            this.Visibility = Visibility.Hidden;
            estudiante.ShowDialog();
            this.Close();
        }
        private void Certificados_Click(object sender, RoutedEventArgs e)
        {
            frmMenuCertificado certificado = new frmMenuCertificado();
            this.Visibility = Visibility.Hidden;
            certificado.ShowDialog();
            this.Close();
        }
        private void Listados_Click(object sender, RoutedEventArgs e)
        {
            frmListados listados = new frmListados();
            this.Visibility = Visibility.Hidden;
            listados.ShowDialog();
            this.Close();
        }
        private void Feligreses_Click(object sender, RoutedEventArgs e)
        {
            frmBusquedaFeligreses feligreses = new frmBusquedaFeligreses();
            this.Visibility = Visibility.Hidden;
            feligreses.ShowDialog();
            this.Close();
        }
        private void Sacramento_Click(object sender, RoutedEventArgs e)
        {
            InscripcionSacramentos sacramentos = new InscripcionSacramentos();
            this.Visibility = Visibility.Hidden;
            sacramentos.ShowDialog();
            this.Close();
        }
        private void Bautismo_Click(object sender, RoutedEventArgs e)
        {
            frmCatequizado catequizadob = new frmCatequizado();
            catequizadob.BgSacramentos.Visibility = Visibility.Hidden;
            catequizadob.Bgvivecon.Visibility = Visibility.Hidden;
            Grid.SetRow(catequizadob.BtaceptarC, 3);
            Grid.SetRow(catequizadob.BtcancelarC, 3);
            this.Visibility = Visibility.Hidden;
            catequizadob.ShowDialog();
        }
        private void PComunion_Click(object sender, RoutedEventArgs e)
        {
            frmCatequizado catequizadopc = new frmCatequizado();
            //Primero de Comunión
            catequizadopc.tbdInPrimeraComunion.Visibility = Visibility.Hidden;
            catequizadopc.cbInPrimeraComunion.Visibility = Visibility.Hidden;
            catequizadopc.tbpInPrimeraComunion.Visibility = Visibility.Hidden;
            catequizadopc.txtInPcomuniomP.Visibility = Visibility.Hidden;
            //Segundo de Comunión
            catequizadopc.tbdInSegundoComunion.Visibility = Visibility.Hidden;
            catequizadopc.cbInSegundoComunion.Visibility = Visibility.Hidden;
            catequizadopc.tbpInSegundoComunion.Visibility = Visibility.Hidden;
            catequizadopc.txtInPcomunionS.Visibility = Visibility.Hidden;
            // Primero Confirmación
            catequizadopc.tbdInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadopc.cbInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadopc.tbpInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadopc.txtInPconfirmacionP.Visibility = Visibility.Hidden;
            // Segundo Confirmación
            catequizadopc.tbdSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadopc.cbInSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadopc.tbpSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadopc.txtInPconfirmacionS.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Hidden;
            catequizadopc.ShowDialog();
        }
        private void SComunion_Click(object sender, RoutedEventArgs e)
        {
            frmCatequizado catequizadosc = new frmCatequizado();
            //Segundo de Comunión
            catequizadosc.tbdInSegundoComunion.Visibility = Visibility.Hidden;
            catequizadosc.cbInSegundoComunion.Visibility = Visibility.Hidden;
            catequizadosc.tbpInSegundoComunion.Visibility = Visibility.Hidden;
            catequizadosc.txtInPcomunionS.Visibility = Visibility.Hidden;
            // Primero Confirmación
            catequizadosc.tbdInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadosc.cbInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadosc.tbpInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadosc.txtInPconfirmacionP.Visibility = Visibility.Hidden;
            // Segundo Confirmación
            catequizadosc.tbdSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadosc.cbInSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadosc.tbpSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadosc.txtInPconfirmacionS.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Hidden;
            catequizadosc.ShowDialog();
        }
        private void PConformacion_Click(object sender, RoutedEventArgs e)
        {
            frmCatequizado catequizadopcf = new frmCatequizado();
            // Primero Comunion
            catequizadopcf.tbdInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadopcf.cbInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadopcf.tbpInPrimeraConfirmacion.Visibility = Visibility.Hidden;
            catequizadopcf.txtInPconfirmacionP.Visibility = Visibility.Hidden;
            // Segundo Comunion
            catequizadopcf.tbdSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadopcf.cbInSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadopcf.tbpSegundoConfirmacion.Visibility = Visibility.Hidden;
            catequizadopcf.txtInPconfirmacionS.Visibility = Visibility.Hidden;
            this.Visibility = Visibility.Hidden;
            catequizadopcf.ShowDialog();

        }
    }
}

