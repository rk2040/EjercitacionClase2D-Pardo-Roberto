using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Validadora
    {

        private static int rangoMinimo;

        private const int RANGO_MAXIMO = 100;    //Solo se pueden declarar aca las constantes (declarar el valor)

        static Validadora()
        {
            Validadora.rangoMinimo = 1;
        }

        public static bool ValidarNumerico(string numeroIngrasado, int valorMinimo, int valorMaximo)
        {
            int numero = int.Parse(numeroIngrasado);

            return Validadora.EsNumerico(numeroIngrasado) && numero > Validadora.rangoMinimo && 
                    numero < Validadora.RANGO_MAXIMO;
        }

        public static bool ValidarNumerico(int numeroIngresado, int valorMinimo, int valorMaximo)
        {


            return Validadora.ValidarNumerico(numeroIngresado.ToString(), valorMinimo, valorMaximo);
        }

        public static bool EsNumerico(string numeroIngresado)  // lo cambie a public para el Ej 4 de la clase 3
        {
            int retorno;

            if(int.TryParse(numeroIngresado, out retorno))
            {
                return true;
            }
            return false;
        }

        public static bool ValidarRangoNumerico(string numeroIngresado, int valorMinimo, int valorMaximo)
        {
            int numero = int.Parse(numeroIngresado);

            return Validadora.EsNumerico(numeroIngresado) && numero > Validadora.rangoMinimo &&
                    numero < Validadora.RANGO_MAXIMO;
        }

        public bool Validar(int valor, int min, int max)
        {
            string numeroString = valor.ToString();
            return Validadora.ValidarRangoNumerico(numeroString, min, max);
        }

        public static bool OpcionSiNo(string mensaje)
        {
            bool opcion = false;
            string opcionSalir;

            Console.WriteLine(mensaje);
            opcionSalir = Console.ReadLine();

            if (opcionSalir.ToLower() == "s") opcion = true;

            return opcion;
        }
    }
}
