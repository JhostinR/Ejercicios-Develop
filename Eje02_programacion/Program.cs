/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 16/03/2022
 * Time: 4:13 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace eje02_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre; //Defiinir/declarar la variable
			Console.WriteLine("Digite su nombre"); // se muestra mensaje al usuario
			nombre = Console.ReadLine();// se capturael dato del usuario
			Console.WriteLine("su nombre es {0}", nombre);
			//---------------------------------------------------
			//INT
			int edad;
			Console.WriteLine("cual es su edad");
			edad =int.Parse(Console.ReadLine());
			Console.WriteLine("su edad es: {0}",edad);
			
			// Double
			Double peso;
			Console.WriteLine("cual es su peso");
			peso = Double.Parse(Console.ReadLine());
			Console.WriteLine("su peso es: {0}", peso);
			
			
			Console.ReadKey();
		}
	}
}