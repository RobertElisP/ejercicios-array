using System;
using System.Linq;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int respuesta;
            double operacion;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Escriba el numero {0}: ", i + 1);
                respuesta = Convert.ToInt32(Console.ReadLine());
                numeros[i] = respuesta;
            }
            operacion = (numeros.Sum() / 4);
            Console.WriteLine("------------------------------");
            Console.WriteLine("El resultado de la operacion es: {0}", operacion);
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Los numeros digitados fueron: ");
            Console.WriteLine("");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Precione ENTER para salir de la aplicacion");


            Console.ReadKey();

        }
    }
}
