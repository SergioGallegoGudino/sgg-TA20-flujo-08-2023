using System;
using System.ComponentModel.DataAnnotations;

namespace CalculadoraInversa
{

    class CalculadoraInversa
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Introduce el primer numero: ");
            String num1String = Console.ReadLine();
            Console.WriteLine("Introduce el segundo numero: ");
            String num2String = Console.ReadLine();
            Console.WriteLine("Introduce un signo aritmetico: ");
            String signo = Console.ReadLine();

            int num1 = int.Parse(num1String);
            int num2 = int.Parse(num2String);

            switch (signo)
            {
                case "+":
                    Console.WriteLine("Resultado: {0}", (num1 + num2));
                break;
                case "-":
                    Console.WriteLine("Resultado: {0}", (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Resultado: {0}", (num1 * num2));
                    break;
                case "/":
                    Console.WriteLine("Resultado: {0}", (num1 / num2));
                    break;
                case "^":
                    Console.WriteLine("Resultado: {0}", Math.Pow(num1, num2));
                    break;
                case "%":
                    Console.WriteLine("Resultado: {0}", (num1 % num2));
                    break;
            }

        }
    }

}