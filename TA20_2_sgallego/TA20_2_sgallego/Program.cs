using System;

namespace Ejercicio2
{

    class Ejercicio2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe un nombre: ");
            String nombre = Console.ReadLine();

            Console.WriteLine("Escribe el nombre de una ciudad: ");
            String ciudad = Console.ReadLine();

            Console.WriteLine("Hola {0} bienvenido a {1}", nombre, ciudad);

        }
    }

}
