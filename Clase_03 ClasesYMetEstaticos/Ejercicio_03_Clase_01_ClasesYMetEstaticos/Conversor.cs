using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Consigna
    Desarollar una clase llamada Conversor que posea dos métodos de clase (estáticos):

    El método ConvertirDecimalABinario que convierte un número entero del sistema decimal al sistema binario.

    public string ConvertirDecimalABinario(int numeroEntero) {}

    El método ConvertirBinarioADecimal que convierte un número entero del sistema binario al sistema decimal.

    public int ConvertirBinarioADecimal(int numeroEntero) {}

    IMPORTANTE
    NO utilizar los atajos del lenguaje, hacerlo mediante estructuras de iteración y selección.
*/

namespace Ejercicio_03_Clase_01_ClasesYMetEstaticos
{
    internal class Conversor
    {


        public static string ConvertirDecimalABinario(int numeroEntero)
        {

            string numeroBinarioStr = "";

            while(numeroEntero > 0)
            {
                numeroBinarioStr = numeroEntero % 2 + numeroBinarioStr;

                numeroEntero /= 2;  //al ser tipo int me lo redondea sin decimal
            }

            

            return numeroBinarioStr;
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
