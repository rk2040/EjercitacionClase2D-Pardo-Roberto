using System;

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
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int resultadoSuma;
            bool salir = false;

            do
            {
                Console.Clear();

                numero1 = Validador.ValidarEsNumero();
                numero2 = Validador.ValidarEsNumero();

                resultadoSuma = numero1 + numero2;

                Console.WriteLine($"La suma de {numero1} + {numero2} es: {resultadoSuma}");


                salir = Validador.ValidarRespuesta("Desea continuar? S/N ");
            } while (salir == false);

        }
    }
}
