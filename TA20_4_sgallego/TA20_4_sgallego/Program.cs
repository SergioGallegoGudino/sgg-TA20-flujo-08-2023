using System;

namespace Ejercicio4
{

    class Ejercicio4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe el primer numero: ");
            String num1String = Console.ReadLine();
            Console.WriteLine("Escribe el segundo numero: ");
            String num2String = Console.ReadLine();

            int num1 = int.Parse(num1String);
            int num2 = int.Parse(num2String);

            if (num1 > num2) {
                Console.WriteLine("El número más grande es {0}", num1);
            } else if (num2 > num1)
            {
                Console.WriteLine("El número más grande es {0}", num2);
            }
            else {
                Console.WriteLine("Los dos número son iguales");
            }

        }
    }

}

