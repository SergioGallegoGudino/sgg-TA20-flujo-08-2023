using System;

namespace Ejercicio14
{

    class Ejercicio14
    {
        public const double PI = 3.1415926535897931;
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce el radio: ");
            String radioString = Console.ReadLine();

            double radio = double.Parse(radioString);
            double area = (Math.Pow(PI, radio))*(Math.Pow(PI, radio));

            Console.WriteLine("El área de {0} es {1}", radio, area);
        }
    }

}