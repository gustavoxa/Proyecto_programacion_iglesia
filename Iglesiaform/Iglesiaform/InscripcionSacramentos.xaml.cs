using System;
using System.Collections.Generic;
using System.Data;
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
using Capadenegocios;
namespace Iglesiaform
{
    /// <summary>
    /// Lógica de interacción para InscripcionSacramentos.xaml
    /// </summary>
    public partial class InscripcionSacramentos : Window
    { DataTable dtVCateEstu;
        validacionCedula v1 = new validacionCedula();
        Autocompletado dtVCE = new Autocompletado();
        public InscripcionSacramentos()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {//-----------------------------

            if (v1.vCedula(txtBusqCeduCz.Text) == 2)
            {
                int i = 0;

                try
                {
                    dtVCateEstu = dtVCE.BuscarFeligreses2(txtBusqCeduCz.Text);
                    txtNombreCz.Text = dtVCateEstu.Rows[0]["NOMBRE"].ToString();
                    txtApeCz.Text = dtVCateEstu.Rows[0]["APELLIDOS"].ToString();
                    txtCedulaCz.Text = dtVCateEstu.Rows[0]["CEDULA"].ToString();
                    dpNaciCz.Text = dtVCateEstu.Rows[0]["FECHA_NACIMIENTO"].ToString();
                    txtTelefCz.Text = dtVCateEstu.Rows[0]["TELEFONO"].ToString();

                    txtCeluCz.Text = dtVCateEstu.Rows[0]["CELULAR"].ToString();
                    txtCallePrincCz.Text = dtVCateEstu.Rows[0]["CALLE_PRINCIPAL"].ToString();
                    txtCalleSecuCz_.Text = dtVCateEstu.Rows[0]["CALLE_SECUNDARIA"].ToString();
                    txtNumCasaCz.Text = dtVCateEstu.Rows[0]["NUMCASA"].ToString();
                    txtSectorCz.Text = dtVCateEstu.Rows[0]["SECTOR"].ToString();
                    txtRefeDirecCz.Text = dtVCateEstu.Rows[0]["REFERENCIA"].ToString();
                    txtFortaCz.Text = dtVCateEstu.Rows[0]["FORTALEZAS"].ToString();
                    txtAlergiaCz.Text = dtVCateEstu.Rows[0]["alergia"].ToString();
                    cbxSangreCz.SelectedItem = dtVCateEstu.Rows[0]["TIPO_DE_SANGRE"].ToString();
                    txtNomPadreCz.Text = dtVCateEstu.Rows[0]["nombrespadre"].ToString();
                    txtApePadreCz.Text = dtVCateEstu.Rows[0]["apellidopadre"].ToString();
                    txtOcupPadreCz.Text = dtVCateEstu.Rows[0]["ocupacionpadre"].ToString();
                    txtNomMadreCz.Text = dtVCateEstu.Rows[0]["nombremadre"].ToString();
                    txtApeMadreCz.Text = dtVCateEstu.Rows[0]["apellidomadre"].ToString();
                    txtOcupMadreCz.Text = dtVCateEstu.Rows[0]["ocupacionmadre"].ToString();
                    txtComuniCz.Text = dtVCateEstu.Rows[0]["casoemergencia"].ToString();
                    txtParentCz.Text = dtVCateEstu.Rows[0]["parentesco"].ToString();
                    txtTelefEmergCz.Text = dtVCateEstu.Rows[0]["telefonorepre"].ToString();
                    txtCeluEmergCz.Text = dtVCateEstu.Rows[0]["celularrepre"].ToString();

                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("No se ha encontrado el registro");
                    txtBusqCeduCz.Text = "";
                    i = 1;
                }

                cbBautismo.IsChecked = dtVCE.Bautismo(txtBusqCeduCz.Text);
                cbPrimeraComunion.IsChecked = dtVCE.comunion1(txtBusqCeduCz.Text);
                cbSegundoComunion.IsChecked = dtVCE.comunion2(txtBusqCeduCz.Text);
                cbPrimeraConfirmacion.IsChecked = dtVCE.conf1(txtBusqCeduCz.Text);
                cbSegundoConfirmacion.IsChecked = dtVCE.conf2(txtBusqCeduCz.Text);
                if (cbBautismo.IsChecked == true)
                {


                    if (cbPrimeraComunion.IsChecked == true)
                    {

                        if (cbSegundoComunion.IsChecked == true & cbPrimeraConfirmacion.IsChecked == false)
                        {
                            rbnComunion.IsChecked = true;
                            txtCeleSacramento.Text = "comunion";

                        }
                        else if (cbSegundoConfirmacion.IsChecked == false)
                        {
                            MessageBox.Show("No tiene celebracion pendiente");
                            rbnBautizo.IsChecked = false;
                            rbnComunion.IsChecked = false;
                            rbnConfirmacion.IsChecked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene celebracion pendiente");
                        rbnBautizo.IsChecked = false;
                        rbnComunion.IsChecked = false;
                        rbnConfirmacion.IsChecked = false;
                    }

                }
                else if (i == 0)
                {
                    rbnBautizo.IsChecked = true;
                    txtCeleSacramento.Text = "Bautismo";

                }


                if (cbBautismo.IsChecked == true)
                {

                    if (cbPrimeraComunion.IsChecked == true)
                    {

                        if (cbSegundoComunion.IsChecked == true)
                        {

                            if (cbPrimeraConfirmacion.IsChecked == true)
                            {

                                if (cbSegundoConfirmacion.IsChecked == true)
                                {
                                    rbnConfirmacion.IsChecked = true;
                                    txtCeleSacramento.Text = "confirmacion";
                                }

                            }
                        }
                    }

                }

            }
            else if (v1.vCedula(txtBusqCeduCz.Text) == 1)
            {
                MessageBox.Show("Numero de cedula incompleto");
            }
            else if (v1.vCedula(txtBusqCeduCz.Text) == 0)
            {
                MessageBox.Show("Numero de cedula incompleto , con caracteres vacios o no numericos ");
            }
            else if (v1.vCedula(txtBusqCeduCz.Text) == 3)
            {
                MessageBox.Show("Numero de cedula completo , con caracteres vacios o no numericos");
            }
            else if (v1.vCedula(txtBusqCeduCz.Text) == 4)
            {
                MessageBox.Show("Ingrese primero el numero de cedula");
            }
            //---------------------------------
            
            
        }

        private void rbnMatrimonio_Checked(object sender, RoutedEventArgs e)
        {
            txtCeleSacramento.Text = "Matrimonio";
        }

        private void btncancelarfrmI_Click(object sender, RoutedEventArgs e)
        {
            if (rbnBautizo.IsChecked == true)
            {
                int idp1, idp2;
                int idE;
                InscripcionEventosS bautizo = new InscripcionEventosS();
                bautizo.guardarP(txtNomPadrino1.Text, txtApePadrino1.Text, txtCorreoPadrino1.Text, txtCeluPadrino1.Text);
                bautizo.guardarP(txtNomPadrino2.Text, txtApePadrino2.Text, txtCorreoPadrino2.Text, txtCeluPadrino2.Text);
                bautizo.guardarEB(txtCedulaCz.Text, DateTime.Parse(dpFechaCele.Text));
                Autocompletado id = new Autocompletado();
                idp1=id.MaxIdPadrinos();
                idp2 = idp1 - 1;
                idE = id.MaxIdB();
                bautizo.guardarPEB(idE, idp1);
                bautizo.guardarPEB(idE, idp2);
            }
            
        }
        private void btnGuardarFrmI_Click(object sender, RoutedEventArgs e)
        {
            menuiglesia form1 = new menuiglesia();
            this.Visibility = Visibility.Hidden;
            form1.ShowDialog();
            this.Close();
        }
    }
}
