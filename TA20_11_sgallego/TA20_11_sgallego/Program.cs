using System;

namespace Ejercicio11
{

    class Ejercicio11
    {
        public static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;

            if (num1 > num2)
            {
                Console.WriteLine("El numero más grande es num1 con {0}", num1);
            } else if (num2 > num1)
            {
                Console.WriteLine("El numero más grande es num2 con {0}", num2);
            }
            else
            {
                Console.WriteLine("Los dos numeros son iguales.");
            }
        }
    }

}
