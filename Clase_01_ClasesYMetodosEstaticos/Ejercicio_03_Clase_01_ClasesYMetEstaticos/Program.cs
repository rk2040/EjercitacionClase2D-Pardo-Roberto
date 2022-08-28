using System;

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
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal;
            string numeroBinarioStr;

            numeroDecimal = Conversor.ValidarEsNumero();
            numeroBinarioStr = Conversor.ConvertirDecimalABinario(numeroDecimal);

            Console.WriteLine($"Convertir el numero decimal a binario:\n" +
                $"Numero en Decimal: {numeroDecimal}\n" +
                $"Numero en Binario: {numeroBinarioStr}"); 
        }
    }
}
