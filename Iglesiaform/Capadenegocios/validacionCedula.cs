using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Capadenegocios
{
    public class validacionCedula
    {
        public int vCedula(String vCedu)
        { 
           
            if(vCedu.Length < 10 & vCedu.Length >0)
            {
                int i, j;
                int aux = 0;
                for (i = 0; i < vCedu.Length; i++)
                {
                    for (j = 0; j <= 9; j++)
                    {
                        if (vCedu.Substring(i, 1) == j.ToString())
                        {
                            aux++;
                            Console.WriteLine("numaux: " + j.ToString());
                        }
                        /*Console.WriteLine(vCedu.Length) ;
                        Console.WriteLine(vCedu.Substring(3,1));/* (posicion, numero de cadena(1))
                        Console.WriteLine("numauxfuera: " + j.ToString());*/
                    }

                }
                if (aux < vCedu.Length)
                {
                    return 0;/*Cedula incompleta eh incorrecta*/
                }
                return 1;/*Cedula incompleta */
            }
            
            if (vCedu.Length == 10)
            {
                int i, j;
                int aux = 0;
                for (i = 0; i < vCedu.Length; i++)
                {
                    for (j = 0; j <= 9; j++)
                    {
                        if (vCedu.Substring(i, 1) == j.ToString())
                        {
                            aux++;
                            Console.WriteLine("numaux: " + aux);
                        }
                        /*Console.WriteLine(vCedu.Length) ;
                        Console.WriteLine(vCedu.Substring(3,1));/* (posicion, numero de cadena(1))
                        Console.WriteLine("numauxfuera: " + j.ToString());*/
                    }

                }
                if ( aux == vCedu.Length)
                {
                    return 2;/*Cedula correcta*/
                }
                return 3;/*Cedula completa eh incorrecta*/

            }
            

            return 4;/*Ingrese primero el numero de cedula*/
        }
    }
}
