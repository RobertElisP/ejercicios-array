using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeroArreglo = new int[5];
            int respuesta;

            Console.WriteLine("--------------------------------");
            for (int i = 0; i < numeroArreglo.Length; i++)
            {
                Console.Write("Escriba el numero {0} ", i +1);
                respuesta = Convert.ToInt32(Console.ReadLine());
                numeroArreglo[i] = respuesta;
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Los numeros invertidos son estos: ");
            Console.WriteLine("");
            foreach (var item in numeroArreglo.Reverse())
            {
                Console.WriteLine(item);
            }



        }
    }
}
