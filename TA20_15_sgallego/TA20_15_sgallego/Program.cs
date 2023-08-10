using System;

namespace Ejercicio15
{

    class Ejercicio15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Indica un número: ");
            String numString = Console.ReadLine();

            int num = int.Parse(numString);

            if (num % 2 == 0)
            {
                Console.WriteLine("El número es divisible entre 2.");
            }
            else
            {
                Console.WriteLine("El número no es divisible entre 2.");
            }
        }
    }

}
