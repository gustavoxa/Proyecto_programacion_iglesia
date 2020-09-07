using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

using negocios;

namespace Iglesiaform
{
	/// <summary>
	/// Lógica de interacción para Window1.xaml
	/// </summary>
	
    
    public partial class frmEstudiante : Window
    {
        public frmEstudiante()
        {
            InitializeComponent();
            //Nota:No borrar esto solo fue para prueba 
            //CertificadoMatrimonio nv = new CertificadoMatrimonio();
            //nv.Show();
           // string a = "Hi";
           // nv.txtEsposo.Text = a;
        }
        Taller metodo = new Taller();
        private void boton1_Click(object sender, RoutedEventArgs e)
        {
            metodo.guardar(txtNombreE.Text);

        }

        private void boton2_Click(object sender, RoutedEventArgs e)
        {
            menuiglesia form1 = new menuiglesia();
            this.Visibility = Visibility.Hidden;
            form1.ShowDialog();
            this.Close();
        }
    }
    
}
