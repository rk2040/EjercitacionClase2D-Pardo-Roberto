using System;
using System.Collections.Generic;
using System.Text;

namespace AhorcadoNetCore
{
  public static  class Menu
    {

        public static void MenuPrincipal()
        {
            int opcionIngresada;
            bool reiniciarJuego = false;
            bool seguirEnElPrograma = true;
            do
            {
                Console.Clear();
                DibujarEncabezado("Bienvenidos");

                OpcionesMenuPrincipal();

                opcionIngresada = Funciones.ValidarEntero(1, 5);
                Console.Clear();

                switch (opcionIngresada)
                {
                    case 1:
                        do
                        {
                            reiniciarJuego = Logica.ComenzarJuego();

                        } while(reiniciarJuego);

                        Console.Clear();
                        break;

                    case 2:
                        Logica.MostrarPalabras();
                        break;

                    case 3:
                        Logica.AgregarPalabraNueva();
                        break;

                    case 4:
                        if (!(Logica.EliminarPalabra()))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Esa palabra no existe en el juego.");
                            Console.ReadLine();
                        }
                        
                        break;

                    case 5:

                        seguirEnElPrograma = false;
                        break;
                }

            } while (seguirEnElPrograma);

        }


        public static void DibujarEncabezado(string textAMostrar)
        {
            string titulo = "*********** " + textAMostrar.Trim() + " ***********";
            string asterisquitos = string.Empty;

            for (int i = 0; i < titulo.Length; i++)
            {
                asterisquitos += "*";
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(asterisquitos);
            Console.WriteLine(titulo);
            Console.WriteLine(asterisquitos);
            Console.WriteLine();

        }

        static void OpcionesMenuPrincipal()
        {
            //for (int i = 0; i < 10; i++)
            //{
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Menu Principal:");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("1. Iniciar Juego");
                Console.WriteLine("2. Mostrar Palabras");
                Console.WriteLine("3. Agregar Palabra Nueva");
                Console.WriteLine("4. Eliminar Palabra");
                Console.WriteLine("5. Salir");

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Ingrese la opción deseada");

                Console.ResetColor();

            //}
        }
    }
}
