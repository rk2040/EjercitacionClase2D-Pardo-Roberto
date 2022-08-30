﻿using System;

using Biblioteca;
/*
    Consigna
    Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

    bool Validar(int valor, int min, int max)

    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    Pedir al usuario que ingrese 10 números enteros. 
    Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

    IMPORTANTE
    Utilizar variables escalares, NO utilizar vectores/arrays.
*/

namespace Ejercicio_01_Clase_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadDeNumerosPedidos = 10;
            int valorMinimo = -100;
            int valorMaximo = 100;
            bool esNumero = false;
            string numeroString;
            int numeroValido;
            int acumulador = 0;
            float promedio = 0.0f;

            Validadora validarNumero = new Validadora();

            Console.WriteLine($"Ingrese {cantidadDeNumerosPedidos} numeros enteros: ");

            for (int i = 0; i < cantidadDeNumerosPedidos; i++)
            {
                do
                {
                    numeroString = Console.ReadLine();
                    esNumero = int.TryParse(numeroString, out numeroValido);

                    if (esNumero && validarNumero.Validar(numeroValido, valorMinimo, valorMaximo))
                    {
                        numeroValido = int.Parse(numeroString);
                        acumulador += numeroValido;
                        Console.WriteLine("Es un numero.\nIngrese otro numero: ");
                    }
                    else
                    {
                        Console.WriteLine("Error, no es un numero.\nIngrese un numero: ");
                    }

                } while (!esNumero);


            }
            promedio = (float)acumulador / cantidadDeNumerosPedidos;

            Console.WriteLine();
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}
