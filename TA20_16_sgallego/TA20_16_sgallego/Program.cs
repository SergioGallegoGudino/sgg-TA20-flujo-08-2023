using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio16
{

    class Ejercicio16
    {
        
        public static void Main(string[] args)
        {
            int IVA = 21;

            Console.WriteLine("Introduce el precio de un producto: ");
            String precioString = Console.ReadLine();

            double precio = Double.Parse(precioString);

            double total = precio + (precio * IVA) / 100;

            Console.WriteLine("El precio total es {0}", total);

        }
    }

}
