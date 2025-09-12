using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer4();
            Console.ReadKey();
        }
        static void ejer1()
        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido al FA de {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Cristian\"");
        }
        static void ejer3()
        {
            Console.Write("Ingrese num 1: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese num 2: ");
            int y = Convert.ToInt32(Console.ReadLine());

            double divi = (double)x / (double)y;

            Console.WriteLine("\nSuma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicacion: " + (x * y));
            Console.WriteLine("Division: " + divi);
        }
        static void ejer4() 
        {
            Console.WriteLine("Ingrese un numero decimal: ");
            double num = double.Parse(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int)Math.Round(num,0);
            double cubo = Math.Pow(num, 3);
            double raiz3 = Math.Pow(num,1/3d);

            Console.WriteLine("\nRaiz2: " + raiz2);
            Console.WriteLine("redondeando: " + redo);
            Console.WriteLine("Al cubo: " + cubo);
            Console.WriteLine("Raiz3: " + raiz3);
        }
    }
}
