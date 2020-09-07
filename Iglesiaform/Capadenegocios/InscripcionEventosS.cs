using System;
using System.Collections.Generic;
using System.Text;
using System;

using System.Linq;

using System.Threading.Tasks;
using CapaDatos;
namespace Capadenegocios
{
    public class InscripcionEventosS
    {
        Class1 BaseD = new Class1();
        public void guardarP(string nombre,string apellido, string correo, string celular)
        {
            List<ParametrosDB> listaP = new List<ParametrosDB>();
            listaP.Add(new ParametrosDB("@nomb", nombre));
            listaP.Add(new ParametrosDB("@apelli", apellido));
            listaP.Add(new ParametrosDB("@correo", correo));
            listaP.Add(new ParametrosDB("@celular", celular));
            BaseD.EjecutarProcedimiento("IngresoPadrinos", listaP);
        }
        public void guardarEB(string cedula, DateTime fecha)
        {
            List<ParametrosDB> listaEB = new List<ParametrosDB>();
            listaEB.Add(new ParametrosDB("@cedula", cedula));
            listaEB.Add(new ParametrosDB("@fechafin", fecha));
         
            BaseD.EjecutarProcedimiento("IngresoEBautizo", listaEB);
        }
        public void guardarPEB(int fkEB, int fkPB)
        {
            List<ParametrosDB> listaPB = new List<ParametrosDB>();
            listaPB.Add(new ParametrosDB("@fkbautiso", fkEB));
            listaPB.Add(new ParametrosDB("@fkpadrino", fkPB));

            BaseD.EjecutarProcedimiento("IngresoPadriBautizo", listaPB);
        }
    }
}
