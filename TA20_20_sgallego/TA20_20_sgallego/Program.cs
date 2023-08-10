using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio20
{

    class Ejercicio20
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero de ventas: ");
            String numVentasString = Console.ReadLine();

            int numVentas = int.Parse(numVentasString);
            double totalVentas = 0;
            for (int i = 0; i < numVentas; i++)
            {
                Console.WriteLine("Introduce las ventas del producto número {0}: ", i+1);
                String ventasProducto = Console.ReadLine();

                totalVentas += int.Parse(ventasProducto);

            }
            Console.WriteLine("El total de ventas es {0}", totalVentas);
        }
    }

}
