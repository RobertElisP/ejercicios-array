using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int respuesta, mayor;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Escriba el numero {0}: ", i + 1);
                respuesta = Convert.ToInt32(Console.ReadLine());
                numeros[i] = respuesta;
            }

            mayor = numeros[0];

            for (int i = 0; i < numeros.Length; i++)
            {

                if (numeros[i]> mayor) { 
                    mayor= numeros[i];
                }
            }

            Console.WriteLine("");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("El numero digitado mayor es: {0}", mayor);
            Console.ReadKey();

        }
    }
}
