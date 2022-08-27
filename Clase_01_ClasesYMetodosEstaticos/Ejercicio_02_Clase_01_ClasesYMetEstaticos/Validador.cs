using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Consigna
    Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
    "¿Desea continuar? (S/N)".

    Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

    El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y 
    FALSE si se ingresó cualquier otro valor.
*/

namespace Ejercicio_02_Clase_01_ClasesYMetEstaticos
{
    internal class Validador
    {

        public static bool ValidarRespuesta(string mensaje)
        {
            bool opcion = false;
            string opcionSiNo;

            Console.WriteLine(mensaje);
            opcionSiNo = Console.ReadLine();

            if (opcionSiNo.ToLower() == "n")
            {
                opcion = true;
            }

            return opcion;
        }

        public static int ValidarEsNumero()
        {
            bool esNumero = false;
            string numeroString;
            int numero;

            Console.WriteLine("Ingrese un numero: ");
            numeroString = Console.ReadLine();

            esNumero = int.TryParse(numeroString, out numero);

            while (!esNumero)
            {
                Console.Clear();
                Console.WriteLine("Error, no es un numero. \nIngrese un numero: ");
                numeroString = Console.ReadLine();
                esNumero = int.TryParse(numeroString, out numero);
            }

            return numero;
        }
    }

}
