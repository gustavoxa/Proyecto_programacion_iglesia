using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace capanegocios
{
    class reegistroestudiantescate
    {
        private string V = "consultarepre";
        DataSet datos;
        public void ultimoregistro() {
            Class1 busqueda = new Class1();
            datos = busqueda.ultimoregistro(V);
        }

           
    }
}
