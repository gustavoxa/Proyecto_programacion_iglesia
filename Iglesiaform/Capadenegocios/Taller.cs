using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace negocios
{
    public class Taller
    {
        Class1 basedatos = new Class1();
        public void guardar(string _nombre)
        {
            List<ParametrosDB> lista = new List<ParametrosDB>();
            lista.Add(new ParametrosDB("@descripcion", _nombre));
            basedatos.EjecutarProcedimiento("Ingreso_Taller", lista);
        }

    }
}