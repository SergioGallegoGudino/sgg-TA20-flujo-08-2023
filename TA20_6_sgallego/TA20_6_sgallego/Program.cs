using System;

namespace Ejercicio6
{

    class Ejercicio6
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe el precio de un producto: ");
            String precioString = Console.ReadLine();

            double precio = double.Parse(precioString);

            if (precio >= 0)
            {
                Console.WriteLine("En efectivo o en tarjeta? ");
                String metodo = Console.ReadLine();

                if (metodo == "Tarjeta")
                {
                    Console.WriteLine("Introduce el número de cuenta.");
                    String cuenta = Console.ReadLine();
                } 

            }
            else
            {
                Console.WriteLine("Error, inténtalo de nuevo.");
            }

        }
    }

}
