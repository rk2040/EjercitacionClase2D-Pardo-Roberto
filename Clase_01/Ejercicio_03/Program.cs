using System;

//Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

//Validar que el dato ingresado por el usuario sea un número.

//Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

//Si ingresa "salir", cerrar la consola.

//Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. 
//De lo contrario, cerrar la consola.

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroString;
            bool esNumero = false;
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese un numero: ");

                numeroString = Console.ReadLine();
                esNumero = int.TryParse(numeroString, out numero);

                if(esNumero == true)
                {
                    EsNumeroPrimo(numero);
                }
                else
                {
                    Console.WriteLine("Error, Reingrese un numero: ");
                    numeroString = Console.ReadLine();
                    esNumero = int.TryParse(numeroString, out numero);

                    EsNumeroPrimo(numero);
                }
                salir = OpcionSiNo("Desea salir? si/no");


            } while (salir == false);

        }

        static bool EsNumeroPrimo(int numero)
        {
            bool esNumeroPrimo = false;
            int contadorPrimos = 0;

            for (int i = 1; i < numero; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        contadorPrimos++;
                    }

                }
                if (contadorPrimos == 2)
                {
                    Console.WriteLine(i);
                }

                contadorPrimos = 0;
            }

            return esNumeroPrimo;
        }

        static bool ValidoNumero(string numeroString)
        {
            bool esNumero = false;
            int numero = 0;

            while (esNumero == false || numero <= 0)
            {
                Console.WriteLine("Error. Reingrese un numero mayor a 0: ");
                numeroString = Console.ReadLine();
                esNumero = int.TryParse(numeroString, out numero);
            }
            return esNumero;
        }

        static bool OpcionSiNo(string mensaje)
        {
            bool opcion = false;
            string opcionSalir;

            Console.WriteLine(mensaje);
            opcionSalir = Console.ReadLine();

            if(opcionSalir.ToLower() == "si")
            {
                opcion = true;
            }

            return opcion;
        }
    }
}
