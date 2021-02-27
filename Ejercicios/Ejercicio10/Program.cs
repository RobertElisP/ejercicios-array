using System;

namespace Ejercicio10
{
    class Program
    {

        public static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Bienvenido ");
                Console.WriteLine("Digite su nombre por favor ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Digite su Edad ");
                int edad = Convert.ToInt32(Console.ReadLine());
                if (edad < 18)
                {
                    Console.WriteLine("Hola {0} usted aun es menor de edad y tiene {1} años de edad", nombre, edad);
                    Menu();
                }
                else
                {
                    Console.WriteLine("Hola {0} usted aun es Mayor de edad y tiene {1} años de edad", nombre, edad);
                    Menu();
                }
            }
            void Menu()
            {
                Console.WriteLine(" ");
                Console.WriteLine("--------------------------------------------------------------- ");
                Console.WriteLine("Desea Continuar? ");
                Console.WriteLine("Si ");
                Console.WriteLine("No ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToUpper() == "SI")
                {
                    Console.Clear();
                    continuar = true;
                }
                else if (respuesta.ToUpper() == "NO")
                {
                    continuar = false;

                    Console.Clear();
                    Console.WriteLine("Hasta Luego ");
                }
                else
                {
                    Menu();
                }
            }
            Console.ReadKey();
        }

    }
}
