using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
           
            /*15. Pedir el lado de un cuadrado, mostrar su área y su perímetro.*/

            double lado, area, perimetro;

            Console.WriteLine("Digite el valor del lado de un cuadrado");
            lado = double.Parse(Console.ReadLine());

            area = lado * lado;
            perimetro = lado * 4;

            Console.WriteLine("El área del cuadrado es {0} y el perímetro es {1}", area, perimetro);

            /*16. Calcular el área de un rectángulo de lados X e Y.*/

            double ladoX, ladoY, area;

            Console.WriteLine("Digite el valor del lado X de un rectángulo");
            ladoX = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor del lado Y de un rectángulo");
            ladoY = double.Parse(Console.ReadLine());

            area = ladoX * ladoY;

            Console.WriteLine("El área del rectángulo es {0}", area);

            /*17. Pedir dos números y decir si son iguales o no.*/

            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Estos números son iguales");
            }
            else
            {
                Console.WriteLine("Estos números son diferentes");
            }

            /*18. Pedir un número e indicar si es positivo o negativo.*/

            double num;

            Console.WriteLine("Digite un número cualquiera");
            num = double.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("Este número es positivo");
            }
            else
            {
                Console.WriteLine("Este número es negativo");
            }

            /*19. Pedir dos números y decir si uno es múltiplo del otro.*/

            double num1, num2, resultado;

            Console.WriteLine("Digite un numero cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro numero cualquiera");
            num2 = double.Parse(Console.ReadLine());

            resultado = num1 * num2;

            Console.WriteLine("{0} multiplicado {1} es {2}", num1, num2, resultado);

            if (resultado % num1 = 0)
            {
                Console.WriteLine("{0} es múltiplo de {1} y {2}", resultado, num1, num2);
            }
            else
            {
                Console.WriteLine("{0} no es múltiplo de {1} y {2}", resultado, num1, num2);
            }

            /*20. Pedir dos números y decir cuál es el mayor.*/

            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", num2, num1);
            }

            /*21. Pedir dos números y decir cuál es el mayor o si son iguales.*/

            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("{0} es mayor que {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales", num1, num2);
            }
            else
            {
                Console.WriteLine("{0} es mayor que {1}", num2, num1);
            }

            /*22. Pedir dos números y mostrarlos ordenados de mayor a menor.*/

            double num1, num2;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1}", num1, num2);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("{0} y {1} son iguales", num1, num2);
            }
            else
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1}", num2, num1);
            }

            /*23. Pedir tres números y mostrarlos ordenados de mayor a menor.*/

            double num1, num2, num3;

            Console.WriteLine("Digite un número cualquiera");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite otro número cualquiera");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 > num3)
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1} , {2}", num1, num2, num3);
            }
            else if (num1 == num2 == num3)
            {
                Console.WriteLine("{0} , {1} y {2} son iguales", num1, num2, num3);
            }
            else
            {
                Console.WriteLine("El orden de mayor a menor es {0} , {1} , {2}", num3, num2, num1);
            }

            Console.ReadKey();
        }
    }
}