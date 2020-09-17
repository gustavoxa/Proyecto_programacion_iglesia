using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capanegocios
{
	public class Programa
	{
		public void PS()
		{
			Console.WriteLine(Singleton.Instance.mensaje);
		}
	}
}
