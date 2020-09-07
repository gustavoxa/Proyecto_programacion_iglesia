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
using Capadenegocios;
namespace Iglesiaform
{
	/// <summary>
	/// Lógica de interacción para Listados.xaml
	/// </summary>
	public partial class frmListados : Window
	{
		DataTable misCateEstudiante;
		Instru_cate_est_catezdo mp = new Instru_cate_est_catezdo();
		string periodo;
		string curso;
		public frmListados()
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

		private void cbxCurso_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{

		}

		private void btnNuevaCons_Click(object sender, RoutedEventArgs e)
		{
			Console.WriteLine(periodo);
			Console.WriteLine(curso);
			if (curso == "Taller")
			{
				misCateEstudiante = mp.BuscarTallerPeriodo(periodo);
				dgListadoAulaF.DataContext = misCateEstudiante.DefaultView;
			}
			else
			{
				misCateEstudiante = mp.BuscarSacramentoPeriodo(periodo);
				dgListadoAulaF.DataContext = misCateEstudiante.DefaultView;
			}

		}

		private void cbxCurso_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
		{
			if (cbxCurso.SelectedIndex == 1)
			{
				curso = "Taller";
			}
			else
			{
				curso = "Sacramento";
			}
		}

		private void cbxPeriodo_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (cbxPeriodo.SelectedIndex == 1)
			{
				periodo = "2020-B";
			}
			else
			{
				periodo = "2020-A";
			}
		}
	}
}
