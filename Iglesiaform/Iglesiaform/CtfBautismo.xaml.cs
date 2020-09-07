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
    /// Lógica de interacción para CtfBautismo.xaml
    /// </summary>
    public partial class CtfBautismo : Window
    {
        public CtfBautismo(string cedula)
        {
            InitializeComponent();
             frmMenuCertificado frmMenu = new frmMenuCertificado();
            Autocompletado BusqBaut = new Autocompletado();
            DataTable dt = new DataTable();
            try
            {
                string a, fecha;
            a = cedula;
               // a = "0451322251";
            dt = BusqBaut.BuscarBauti(a);
            tbkNomBauti.Text = dt.Rows[0]["nombre"].ToString();
            tbkApeBauti.Text = dt.Rows[0]["apellidos"].ToString();
            tbkNomParroco.Text = "Romel";
            tbkApeParroco.Text = "Vivanco";
            fecha = dt.Rows[0]["fechafin"].ToString();
            tbkAno.Text = fecha.Substring(6, 4);
            tbkMes.Text = fecha.Substring(3, 2);
            tbkDia.Text = fecha.Substring(0, 2);
        }
            catch (System.IndexOutOfRangeException)
            {
                MessageBox.Show("No se ha encontrado el registro");
                frmMenu.txtCedulaF.Text = "";
                
            }

        }
    }
}
