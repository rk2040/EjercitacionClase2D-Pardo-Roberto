using System;

using Biblioteca;

/*
    Consigna
    Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

    Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

    Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. 
    El método devolverá el resultado de la operación.

    Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando 
    la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.

    Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar 
    (ingresando el caracter +, -, * o /).

    El usuario decidirá cuándo finalizar el programa.
*/

namespace Ejercicio_04_Clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerOperando;
            int segundoOperando;
            float resultado;
            string operacion;
            bool opcionContinuar = false;
            bool esNumero = false;

            do
            {
                Console.Clear();
                Console.WriteLine("==== Calculadora ====\n");
                Console.WriteLine("Ingrese el primer Operando");
                esNumero = int.TryParse(Console.ReadLine(), out primerOperando);
                while (!esNumero)
                {
                    Console.WriteLine("Error. Ingrese el primer Operando");
                    esNumero = int.TryParse(Console.ReadLine(), out primerOperando);
                }

                Console.WriteLine("Ingrese el segundo Operando");

                esNumero = int.TryParse(Console.ReadLine(), out segundoOperando);
                while (!esNumero)
                {
                    Console.WriteLine("Error. Ingrese el segundo Operando");
                    esNumero = int.TryParse(Console.ReadLine(), out segundoOperando);
                }
                Console.WriteLine("Ingrese tipo de operacion: +   -   *   /");
                operacion = Console.ReadLine();
                while(operacion != "+" && operacion != "-" && operacion != "*" && operacion != "/")
                {
                    Console.WriteLine("Error. Ingrese tipo de operacion: +   -   *   /");
                    operacion = Console.ReadLine();
                }

                resultado = (float)Calculadora.Calcular(primerOperando, segundoOperando, operacion);


                Console.WriteLine($"El resultado de la operacion: " +
                    $"{primerOperando} {operacion} {segundoOperando} es {resultado} \n");

                opcionContinuar = Validadora.OpcionSiNo("Desea salir de la calculadora? S/N");
            } while (!opcionContinuar);
        }
    }
}
