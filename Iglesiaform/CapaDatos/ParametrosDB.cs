using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class ParametrosDB
    {
        public String nombre { get; set; }
        public Object valor { get; set; }
        public SqlDbType tipoDato { get; set; }
        public Int32 tamano { get; set; }

        public ParameterDirection parDBdirection { get; set; }
        // Para especificar los parámetros de entrada
        public ParametrosDB(string _nombre, Object _valor)
        {
            nombre = _nombre;
            valor = _valor;
            parDBdirection = ParameterDirection.Input;
        }
        // Para especificar los parámetros de salida
        public ParametrosDB(string _nombre, SqlDbType _tipoDato, Int32 _tamano)
        {
            nombre = _nombre;
            tipoDato = _tipoDato;
            tamano = _tamano;
            parDBdirection = ParameterDirection.Output;

        }


    }
}
