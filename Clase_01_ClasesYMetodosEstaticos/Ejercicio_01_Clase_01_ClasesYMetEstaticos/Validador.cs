using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Consigna
    Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

    bool Validar(int valor, int min, int max)

    valor: dato a validar.
    min: mínimo valor incluido.
    max: máximo valor incluido.
    Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que 
    estén dentro del rango -100 y 100.

    Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
*/

namespace Ejercicio_01_Clase_01_ClasesYMetEstaticos
{
    public class Validador
    {
        int valor;
        int valorMinimo;
        int valorMaximo;

        public Validador(int valor, int valorMinimo, int valorMaximo)
        {
            this.valor = valor;
            this.valorMinimo = valorMinimo;
            this.valorMaximo = valorMaximo;
        }

        public static bool Validar(int valor, int min, int max)
        {
            bool esNumero = false;

            if (valor >= min && valor <= max) esNumero = true;

            return esNumero;
        }

        public static int EsNumero(string numeroString)
        {
            bool esNumero = false;
            int numero = 0;


            do
            {
               // Console.WriteLine("Ingrese un numero: ");
                numeroString = Console.ReadLine();
                esNumero = int.TryParse(numeroString, out numero);

                if(!esNumero) Console.WriteLine("Error, no es un numero.");
            } while (esNumero == false) ;
                return numero;
        }
    }


}
