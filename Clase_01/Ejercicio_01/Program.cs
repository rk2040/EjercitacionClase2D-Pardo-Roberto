using System;

/*
	Consigna
	Ingresar 5 números por consola, guardándolos en una variable escalar. 
	Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
*/

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int numeroMaximo = int.MinValue;
            int numeroMinimo = int.MaxValue;
            int acumuladorDeNumeros = 0;
            int cantidadDeNumeros = 0;
            float promedioNumIngresados = 0.0f;

            for (int i = 0; i < 5; i++)
            {
                numeros[i] = pidoNumeros();

                acumuladorDeNumeros += numeros[i];
                cantidadDeNumeros++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Numero {i + 1}: {numeros[i]}");

                numeroMaximo = mayorNumero(numeros[i], numeroMaximo);

                numeroMinimo = menorNumero(numeros[i], numeroMinimo);
            }
            promedioNumIngresados = promedio(acumuladorDeNumeros, cantidadDeNumeros);

            Console.WriteLine($"Mayor numero: {numeroMaximo} \nMenor numero: {numeroMinimo} \nEl promedio de los numeros es: {promedioNumIngresados}");



        }

        static int pidoNumeros()
        {
            int numero = 0;
            string numeroString;
            bool stringANumero;

            Console.WriteLine("Ingrese un numero: ");
            numeroString = Console.ReadLine();
            stringANumero = int.TryParse(numeroString, out numero);

            while (stringANumero == false)
            {
                Console.WriteLine("Error, no es un numero. \nIngrese un numero: ");
                numeroString = Console.ReadLine();
                stringANumero = int.TryParse(numeroString, out numero);
            } 

            numero = int.Parse(numeroString);

            return numero;
        }

        static int mayorNumero(int num1, int num2)
        {
            int mayor = 0;

            if (num1 > num2)
            {
                mayor = num1;
            }
            else
            {
                mayor = num2;
            }

            return mayor;
        }

        static int menorNumero(int num1, int num2)
        {
            int menor = 0;

            if (num1 < num2)
            {
                menor = num1;
            }
            else
            {
                menor = num2;
            }

            return menor;
        }

        static float promedio(int num1, int num2)
        {
            float resultado = (float)  num1 / num2;

            return resultado;
        }
    }
}
