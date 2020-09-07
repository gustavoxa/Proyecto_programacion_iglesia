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
using Capadenegocios;
using System.Data;
namespace Iglesiaform
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class frmMenuCertificado : Window
    {
        validacionCedula v1 = new validacionCedula();
        public frmMenuCertificado()
        {
            InitializeComponent();
        }

      

        private void btnConsultar_Click(object sender, RoutedEventArgs e)
        {

            if (v1.vCedula(txtCedulaF.Text) == 2)
            {
                if (cbBautizoCz.IsChecked == true)
                {
                   CtfBautismo frm = new CtfBautismo(txtCedulaF.Text);

                    frm.Show();
                }

            }
            else if (v1.vCedula(txtCedulaF.Text) == 1)
            {
                MessageBox.Show("Numero de cedula incompleto");
            }
            else if (v1.vCedula(txtCedulaF.Text) == 0)
            {
                MessageBox.Show("Numero de cedula incompleto , con caracteres vacios o no numericos ");
            }
            else if (v1.vCedula(txtCedulaF.Text) == 3)
            {
                MessageBox.Show("Numero de cedula completo , con caracteres vacios o no numericos");
            }
            else if (v1.vCedula(txtCedulaF.Text) == 4)
            {
                MessageBox.Show("Ingrese primero el numero de cedula");
            }

        }

        private void btnRetornar_Click(object sender, RoutedEventArgs e)
        {
            menuiglesia form1 = new menuiglesia();
            this.Visibility = Visibility.Hidden;
            form1.ShowDialog();
            this.Close();
        }
    }
}
