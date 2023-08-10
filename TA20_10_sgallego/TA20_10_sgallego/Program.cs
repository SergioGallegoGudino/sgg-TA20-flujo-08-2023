using System;

namespace Ejercicio10
{

    class Ejercicio10
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0 || i%3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}
