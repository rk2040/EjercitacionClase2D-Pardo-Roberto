using System;

/*
     * Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
     * Se debe validar que el número sea mayor que cero,  contrario, 
     * mostrar el mensaje: "ERROR. ¡Reingresar número!".
 */

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadradoDeNumero;
            double cuboDeNumero;
            

            numero = pidoNumeros();

            cuadradoDeNumero = Math.Pow(numero, 2);

            cuboDeNumero = Math.Pow(numero, 3);

            Console.WriteLine($"El cuadrado de {numero} es: {cuadradoDeNumero}.\nEl cubo de {numero} es: {cuboDeNumero}");
            
        }

        static int pidoNumeros()
        {
            int numero = 0;
            string numeroString;
            bool stringANumero;

            Console.WriteLine("Ingrese un numero: ");
            numeroString = Console.ReadLine();
            stringANumero = int.TryParse(numeroString, out numero);

            while (stringANumero == false || numero <= 0)
            {
                Console.WriteLine("Error. Reingrese un numero: ");
                numeroString = Console.ReadLine();
                stringANumero = int.TryParse(numeroString, out numero);
            } 

            numero = int.Parse(numeroString);

            return numero;
        }
    }
}
