using System;

namespace Ejercicio5
{

    class Ejercicio5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escribe un día de la semana (primera mayúscula, sin tildes): ");
            String diaSemana = Console.ReadLine();

            if (diaSemana == "Sabado" || diaSemana == "Domingo")
            {
                Console.WriteLine("Es fin de samana");
            } else if (diaSemana == "Lunes" || diaSemana == "Martes" || diaSemana == "Miercoles" || diaSemana == "Jueves" || diaSemana == "Viernes")
            {
                Console.WriteLine("No es fin de semana");
            }
            else
            {
                Console.WriteLine("Error, inténtalo de nuevo");
            }

        }
    }

}
