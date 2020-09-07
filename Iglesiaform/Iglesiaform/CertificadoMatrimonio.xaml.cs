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
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Iglesiaform
{
    /// <summary>
    /// Lógica de interacción para CertificadoMatrimonio.xaml
    /// </summary>
    public partial class CertificadoMatrimonio : Window
    {
        public CertificadoMatrimonio()
        {
            InitializeComponent();
            //Window2 w2 = new Window2();
            
           // ClaseMenuCertificados DatosP = new ClaseMenuCertificados();
            //DataTable TablaPareja = new DataTable();
            //TablaPareja = DatosP.TablaPareja();
           // txtEsposo.Text = TablaPareja.Rows[1]["cedulanovio"].ToString();
           // txtEsposa.Text = TablaPareja.Rows[0]["cedulanovia"].ToString();
        }
         public void Mostrar2()
        { this.Hide();
            
        }
        public void bbb(object sender, TextChangedEventArgs e)
        {

            
            
        }
    }
}
