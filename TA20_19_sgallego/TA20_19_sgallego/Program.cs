﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio19
{

    class Ejercicio19
    {

        public static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                if (i%2 == 0 && i%3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }

}

