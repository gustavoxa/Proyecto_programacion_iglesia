using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace Capadenegocios
{
   public class Instru_cate_est_catezdo
    {
        Class1 basedatos = new Class1();
        public string Cedula { get; set; }
        public Instru_cate_est_catezdo()
        {
        }
        public Instru_cate_est_catezdo(string Cedula)
        {
           
            this.Cedula = Cedula;
        }
        public void guardarnombres(string _cedula, string _nombre, string _apellido, string _fecha, string _correo, string _alergia, int tiposangre, string facebook, string celular, string telefono, int direccion, string fortalezas, int representante)
        {
            List<ParametrosDB> lista = new List<ParametrosDB>();
            lista.Add(new ParametrosDB("@cedula_caes", _cedula));
            lista.Add(new ParametrosDB("@nombre", _nombre));
            lista.Add(new ParametrosDB("@apellidos", _apellido));
            lista.Add(new ParametrosDB("@fecha_nacimiento", _fecha));
            lista.Add(new ParametrosDB("@correo_cate", _correo));
            lista.Add(new ParametrosDB("@alergia", _alergia));
            lista.Add(new ParametrosDB("@tipo_sangre", tiposangre));
            lista.Add(new ParametrosDB("@facebook", facebook));
            lista.Add(new ParametrosDB("@celulares", celular));
            lista.Add(new ParametrosDB("@telefonoes", telefono));
            lista.Add(new ParametrosDB("@direccion", direccion));
            lista.Add(new ParametrosDB("@fortalezas", fortalezas));
            lista.Add(new ParametrosDB("@representante", representante));
            basedatos.EjecutarProcedimiento("Ingreso_CateEstudiante", lista);
        }
        public void guardardireccion(string calleprincipial, string callesecundaria, string ncasa, string referencia, string sector)
        {
            List<ParametrosDB> listadir = new List<ParametrosDB>();
            listadir.Add(new ParametrosDB("@calleP", calleprincipial));
            listadir.Add(new ParametrosDB("@calleS", callesecundaria));
            listadir.Add(new ParametrosDB("@numCasa", ncasa));
            listadir.Add(new ParametrosDB("@ref", referencia));
            listadir.Add(new ParametrosDB("@sector", sector));
            basedatos.EjecutarProcedimiento("Ingreso_Direccion", listadir);
        }
            // busqueda feligreses
        public DataTable BuscarFeligreses(String cedula)
        {
            return basedatos.BuscarFeligreses(cedula);
        }
        public DataTable BuscarTallerPeriodo(String periodo)
        {
            return basedatos.BuscarTallerPeriodo(periodo);
        }
        public DataTable BuscarSacramentoPeriodo(String periodo)
        {
            return basedatos.BuscarSacramentoPeriodo(periodo);
        }
        public DataTable BuscarSacramento()
        {
            return basedatos.BuscarSacramento();
        }
        public DataTable BuscarTaller()
        {
            return basedatos.BuscarTaller();
        }
    }
}