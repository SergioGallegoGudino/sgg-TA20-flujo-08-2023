using System;

namespace Ejercicio3
{

    class Ejercicio3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu edad: ");
            string edadString = Console.ReadLine();
            int edad = int.Parse(edadString);


            Console.WriteLine("Te llamas {0} y tienes {1} años", nombre, edad);

        }
    }

}

