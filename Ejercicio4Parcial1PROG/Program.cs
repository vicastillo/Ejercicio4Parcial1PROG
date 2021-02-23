using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4Parcial1PROG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Double num1, num2, num3;
            Console.Title = ("Encuentra números mayores y menores");


            Console.WriteLine("Digite el primer número:");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo número:");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer número:");
            num3 = Double.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("El primer número (" + num1 + ") es el mayor.");
            }
            else if (num2 > num3)
            {
                
                Console.WriteLine("El segundo número (" + num2 + ") es mayor que el primer número (" + num1 + ") y que el tercer número ingresado (" + num3 + ").");
            }
            else
            {
                Console.WriteLine("El tecer número (" + num3 + ") es menor que el primer número (" + num1 + ") y que el segundo número ingresado (" + num2 + ").");
            }

            Console.ReadKey();
        }
    }
}
