using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Cuenta
    {
        //Atributos
        public string titular;
        public double cantidad;


        //Constructor
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        //Metodos
        public string GetTitularCuenta()
        {
            return "Titular de la cuenta: " + titular;
        }

        public string GetCantidadCuenta()
        {
            return "Cantidad en la cuenta: $" + cantidad;
        }

        public void Mostrar(Cuenta unaCuenta)
        {
            string infoCuenta;

            infoCuenta = unaCuenta.GetTitularCuenta() + ". " + unaCuenta.GetCantidadCuenta();

            Console.WriteLine(infoCuenta);
        }

        public void Ingresar(double montoIngrasado)
        {
            if(montoIngrasado > 0)
            {
                cantidad += montoIngrasado;
            }
        }

        public void Retira(double montoRetirado)
        {
            cantidad -= montoRetirado;
        }
    }

}
