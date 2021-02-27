using System;
using System.Threading;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool repeat =true;
            int respuesta;
            

            while (repeat)
            {
                try
                {
                    Console.WriteLine("----------------------------------------");
                    Console.Write("");
                    Console.Write("Ingrese un numero: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("se generará la tabla del {0}", numero);
                    Console.WriteLine("");
                    Console.WriteLine("Espere, Se está generando  la tabla...");
                    Thread.Sleep(3000);
                    for (int i = 0; i < 13; i++)
                    {
                        Console.WriteLine("" + numero + " X " + i + ": " + numero * i);
                    }
                    Console.Write("");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("Escriba -1 para salir del sistema o cualquier otro numero para continuar");
                    Console.Write("Respuesta: ");
                    respuesta = Convert.ToInt32(Console.ReadLine());

                    if (respuesta == -1)
                    {
                        Console.Write("");
                        repeat = false;
                        Console.WriteLine("Hasta luego");
                    }
                }
                catch (Exception ex)
                {
                    Console.Write("");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine(ex.Message);
                }
               
            }

        }
    }
}
