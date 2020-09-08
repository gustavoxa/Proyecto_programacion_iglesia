using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace Capadenegocios
{
    public class Autocompletado
    {
        Class1 BDT = new Class1();

        public DataTable BuscarFeligreses2(String cedula)
        {
            return BDT.BuscarFeligreses2(cedula);
        }
        public DataTable BuscarBauti(String cedula)//Cargar en certificado bautizo 
        {
            return BDT.BuscarBautizo(cedula);
        }

        public bool Bautismo(String cedula)
        {
            DataTable Bautismo = new DataTable();
            try
            {
                Bautismo = BDT.BuscarBautizo(cedula);

                Bautismo.Rows[0]["cedula"].ToString();
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }
        public bool comunion1(String cedula)
        {
            DataTable comu1 = new DataTable();
            try
            {
               comu1 = BDT.Buscarcomunion1(cedula);

                comu1.Rows[0]["cedula"].ToString();
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }
        public bool comunion2(String cedula)
        {
            DataTable comu2 = new DataTable();
            try
            {
                comu2 = BDT.Buscarcomunion2(cedula);

                comu2.Rows[0]["cedula"].ToString();
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }
        public bool conf1(String cedula)
        {
            DataTable con1 = new DataTable();
            try
            {
                con1 = BDT.Buscarconfi1(cedula);

                con1.Rows[0]["cedula"].ToString();
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }
        public bool conf2(String cedula)
        {
            DataTable con2 = new DataTable();
            try
            {
                con2 = BDT.Buscarconfi2(cedula);

                con2.Rows[0]["cedula"].ToString();
            }
            catch (System.IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }
        public int MaxIdPadrinos()
        {
            DataTable MaxP = new DataTable();
            int id=0;
            try
            {
                MaxP = BDT.BUltimoId();

                id = Int32.Parse(MaxP.Rows[0]["idpadrino"].ToString());
            }
            catch (System.IndexOutOfRangeException)
            {
                return 0;
            }
            return id;
        }
        public int MaxIdB()
        {
            DataTable MaxB = new DataTable();
            int id = 0;
            try
            {
                MaxB = BDT.BaUltimoId();

                id = Int32.Parse(MaxB.Rows[0]["idbautismo"].ToString());
            }
            catch (System.IndexOutOfRangeException)
            {
                return 0;
            }
            return id;
        }

    }

}
