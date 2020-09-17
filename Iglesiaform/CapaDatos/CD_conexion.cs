using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class Class1
    {
         SqlConnection Conexion = new SqlConnection("Server=XAVIER\\SQLEXPRESS;Database=Parroquia7;Integrated Security=True");
         //SqlConnection Conexion = new SqlConnection("Data Source=dell\\debianlock;Initial Catalog=Parroquia6;Integrated Security=True");
        public Class1() { }
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            { 
                Conexion.Open();
            }
            Console.WriteLine("Estado de la conexion con la BD" + Conexion.State.ToString());
            return Conexion;
        }
        
        // Metodo para cerrar la conexión
        public void CerrarConexion()

        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }

        // Metodo para ejecutar procedures - Insert, Delete, Update
        public void EjecutarProcedimiento(String _nombreproc, List<ParametrosDB> _lstParametros)
        {
            SqlCommand sqlcmd;
            try
            {
                AbrirConexion();
                sqlcmd = new SqlCommand(_nombreproc, Conexion);
                sqlcmd.CommandType = CommandType.StoredProcedure;

                if (_lstParametros != null)
                {
                    //Asigna los parametros necesarios para la ejecución del procedimiento
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {

                        if (_lstParametros[i].parDBdirection == ParameterDirection.Input)
                            sqlcmd.Parameters.AddWithValue(_lstParametros[i].nombre, _lstParametros[i].valor);

                        if (_lstParametros[i].parDBdirection == ParameterDirection.Output)
                            sqlcmd.Parameters.Add(_lstParametros[i].nombre, _lstParametros[i].tipoDato, _lstParametros[i].tamano).Direction = ParameterDirection.Output;

                    }
                    sqlcmd.ExecuteNonQuery();
                    // Recupera parametros de salida
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {
                        if (_lstParametros[i].parDBdirection == ParameterDirection.Output)
                            _lstParametros[i].valor = sqlcmd.Parameters[i].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            CerrarConexion();
        }


        // Metodo para hacer consultas
        public DataTable registros(String _nombreproc, List<ParametrosDB> _lstParametros)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlda;

            try
            {

                sqlda = new SqlDataAdapter(_nombreproc, Conexion);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;

                if (_lstParametros != null)
                {
                    for (int i = 0; i < _lstParametros.Count; i++)
                    {
                        sqlda.SelectCommand.Parameters.AddWithValue(_lstParametros[i].nombre, _lstParametros[i].valor);

                    }
                }
                sqlda.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dt;
        }
        // Busqueda Feligreses
        public DataTable BuscarFeligreses(string cedula)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM BusquedaFeligreses Where CEDULA = '" + cedula + "' ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable BuscarFeligreses2(string cedula)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM BusquedaFeligresesT Where CEDULA = '" + cedula + "' ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable BuscarBautizo(string cedula)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM BautizadosNombre Where cedula = '" + cedula + "' ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable Buscarcomunion1(string cedula)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblcomunion1 Where cedula = '" + cedula + "' ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable Buscarcomunion2(string cedula)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblcomunion2 Where cedula = '" + cedula + "' ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable Buscarconfi1(string cedula)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblconfirmacion1 Where cedula = '" + cedula + "' ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable Buscarconfi2(string cedula)
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM tblconfirmacion2 Where cedula = '" + cedula + "' ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable BUltimoId()
        {
            DataTable dt = new DataTable();
            //SELECT* FROM  WHERE id = (SELECT max(id) FROM TableName)
            string query = "SELECT * FROM tblpadrinos Where idpadrino =( SELECT max(idpadrino) FROM tblpadrinos) ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable BaUltimoId()
        {
            DataTable dt = new DataTable();
            //SELECT* FROM  WHERE id = (SELECT max(id) FROM TableName)
            string query = "SELECT * FROM tblbautismo Where idbautismo =( SELECT max(idbautismo) FROM tblbautismo) ;";
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        //-----------------------------------------------------
        public DataTable BuscarTallerPeriodo(string periodo)
        {
            DataTable dt = new DataTable();
            string query = "select* from BusquedaTaller where periodo = '" + periodo + "' ;";

            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable BuscarTaller()
        {
            DataTable dt = new DataTable();
            string query = "select* from BusquedaTaller ;";

            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable BuscarSacramentoPeriodo(string periodo)
        {
            DataTable dt = new DataTable();
            string query = "select* from BusquedaSacramento where periodo = '" + periodo + "' ;";

            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataTable BuscarSacramento()
        {
            DataTable dt = new DataTable();
            string query = "select* from BusquedaSacramento ;";

            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                adapter.SelectCommand = new SqlCommand(query, Conexion);
                AbrirConexion();
                adapter.Fill(dt);
                CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return dt;
        }
        public DataSet ultimoregistro(String _nombreproc)
        {
            SqlCommand sqlcmd;
            try
            {
                AbrirConexion();
                sqlcmd = new SqlCommand(_nombreproc, Conexion);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            
        }


    }
}
