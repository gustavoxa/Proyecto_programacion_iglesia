﻿using System;
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
using capanegocios;
using Capadenegocios;

namespace Iglesiaform
{
	/// <summary>
	/// Lógica de interacción para frmBusquedaFeligreses.xaml
	/// </summary>
	public partial class frmBusquedaFeligreses : Window
	{
		Programa programa = new capanegocios.Programa();
		DataTable misCateEstudiante;
		validacionCedula v1 = new validacionCedula();
		Instru_cate_est_catezdo mp = new Instru_cate_est_catezdo();
		public frmBusquedaFeligreses()
		{
			InitializeComponent();
		}

		private void btnNuevaConsF_Click(object sender, RoutedEventArgs e)
		{
			
            if (v1.vCedula(txtCedulaF.Text)==2)
            {
				misCateEstudiante = mp.BuscarFeligreses(txtCedulaF.Text);

				dgListadoF.DataContext = misCateEstudiante.DefaultView;
				
			}
			else if(v1.vCedula(txtCedulaF.Text) == 1)
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

			programa.PS();


		}
		private void btnCancelarConsF_Click(object sender, RoutedEventArgs e)
		{
			menuiglesia form1 = new menuiglesia();
			this.Visibility = Visibility.Hidden;
			form1.ShowDialog();
			this.Close();
		}

		

		

		}
	}
