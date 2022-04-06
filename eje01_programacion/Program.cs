/*
 * Created by SharpDevelop.
 * User: SENA
 * Date: 16/03/2022
 * Time: 2:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace eje01_programacion
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Numeros enteros
			byte num1 = 30; // Definicion y asignacion
			ushort num2 = 20000;
			int num3 = 50000;
			long num4; // Definicion
			num4 = 6000000; //Asignacion
			
			Console.WriteLine("el numero 1 es: " + num1);
			Console.WriteLine("el numero 2 es: " + num2);
			Console.WriteLine("el numero 3 es: " + num3);
			Console.WriteLine("el numero 4 es: " + num4);
			
			// Numeros decimales
			float peso = (float)50.5;
			double altura = 1.75;
			decimal promedio = (decimal)5.89;
			
			Console.WriteLine("El peso (float) 1 es: " + peso);
			Console.WriteLine("La altura (double) 2 es: " + altura);
			Console.WriteLine("El promedio (decimal) 3 es: " + promedio);
			
			// caracteres
			char genero = 'M';
			bool esAprendiz = true;
			
			Console.WriteLine("genero> "+genero);
			Console.WriteLine("Es Aprendiz> " +esAprendiz);
			
			
			//strings
			string nombre = "Anaelsa Rodriguez";
			string direccion = "Calle 5 # 3 - 123";
			
			Console.WriteLine("Nombre> " + nombre);
			Console.WriteLine("Direccion> " + direccion);
			
			const double PI = 3.1416;
			Console.WriteLine("PI> " + PI);
			
			Console.ReadKey(true);
			                  
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}