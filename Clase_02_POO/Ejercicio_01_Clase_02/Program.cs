using System;

/*
    Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

    Deberá tener los atributos:

    titular que contendrá la razón social del titular de la cuenta.
    cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
    Construir los siguientes métodos para la clase:

    Un constructor que permita inicializar todos los atributos.
    Un método getter para cada atributo.
    mostrar retornará una cadena de texto con todos los datos de la cuenta.
    ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
    retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
    En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
*/

namespace Ejercicio_01_Clase_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float ingreso1 = 5000f;
            float ingreso2 = 7000f;
            float retiro1 = 80000f;
            float retiro2 = 30000f;

            Cuenta cuenta01 = new Cuenta("Roberto", 100000);

            Console.WriteLine("Datos de la Cuenta:");
            Console.WriteLine(cuenta01.GetTitularCuenta());
            Console.WriteLine(cuenta01.GetCantidadCuenta());
            Console.ReadLine();

            Console.WriteLine("Primer ingreso: $" + ingreso1);
            cuenta01.Ingresar(ingreso1);
            cuenta01.Mostrar(cuenta01);
            Console.ReadLine();

            Console.WriteLine("Primer Retiro: $" + retiro1);
            cuenta01.Retira(retiro1);
            cuenta01.Mostrar(cuenta01);
            Console.ReadLine();

            Console.WriteLine("Segundo Retiro: $" + retiro2);
            cuenta01.Retira(retiro2);
            cuenta01.Mostrar(cuenta01);
            Console.ReadLine();

            Console.WriteLine("Segundo ingreso: $" + ingreso2);
            cuenta01.Ingresar(ingreso2);
            cuenta01.Mostrar(cuenta01);
            Console.ReadLine();
        }
    }




}
