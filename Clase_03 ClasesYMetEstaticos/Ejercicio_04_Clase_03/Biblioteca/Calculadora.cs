using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Calculadora
    {

        public static float Calcular(int operador1, int operador2, string operacion)
        {
            float resultado = 0.0f;

            switch (operacion)
            {
                case "+":
                    resultado = (float)operador1 + operador2;
                    break;
                case "-":
                    resultado = (float)operador1 - operador2;
                break;
                case "*":
                    resultado = (float)operador1 * operador2;
                    break;
                case "/":
                    if (Validar(operador2)) resultado = (float)operador1 / operador2;
                    else Console.WriteLine("El divisor no puede ser cero.");
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private static bool Validar(int operador2)
        {
            bool resultado = false;
            if(operador2 != 0) resultado = true;
            return resultado;
        }
    }
}
