using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio21
{

    class Ejercicio21
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Introduce un dia de la semana (primera mayuscula, sin tildes): ");
            String dia = Console.ReadLine();

            switch (dia)
            {
                case "Lunes":
                case "Martes":
                case "Miercoles":
                case "Jueves":
                case "Viernes":
                    Console.WriteLine("Es un día laboral");
                break;
                default: 
                    Console.WriteLine("No es un dia laboral.");
                break;
            }
        }
    }

}
