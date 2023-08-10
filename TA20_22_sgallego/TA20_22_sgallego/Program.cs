using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio22
{

    class Ejercicio22
    {

        public static void Main(string[] args)
        {
            string passwd = "Patata1";
            int intentos = 3;
            bool correcto = false;

            while (!correcto)
            {
                Console.WriteLine("Introduce la contraseña: ");
                string passwdIntento = Console.ReadLine();

                if (passwdIntento == passwd)
                {
                    correcto = true;
                    break;
                }
                else
                {
                    intentos--;
                    Console.WriteLine("Contraseña incorrecta, te quedan {0} intentos", intentos);
                }

                if (intentos == 0)
                {
                    break;
                }

            }

            if (correcto)
            {
                Console.WriteLine("Contraseña correcta, bienvenido");
            }
            else
            {
                Console.WriteLine("Se acabaron los intentos, espere 24 horas para volver a intentarlo.");
            }

        }
    }

}
