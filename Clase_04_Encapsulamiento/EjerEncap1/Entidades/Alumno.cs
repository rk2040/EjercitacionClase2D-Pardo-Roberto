using System;

namespace Entidades
{
    public class Alumno
    {
        public int nota1;
        public int nota2; 
        public string apellido;
        public string nombre;
        public int legajo;

        public Alumno(string apellido, string nombre, int legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public Alumno(string apellido, string nombre, int legajo, int nota1, int nota2) :this(apellido,nombre,legajo)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }


        public int Nota1
        {
            set
            {
                if(nota1 != value)
                {
                    nota1 = value;
                }
            }
        }

        public int Nota2
        {
            set
            {
                if (nota2 != value)
                {
                    nota2 = value;
                }
            }
        }

        public string Apellido
        {
            set
            {
                if(apellido != value)
                {
                    apellido = value;
                }
            }
        }

        public string Nombre
        {
            set
            {
                if(nombre != value)
                {
                    nombre = value;
                }
            }
        }


        public int CalcularNotaFinal()
        {
            if(this.nota1 > 4 && this.nota2 > 4)
            {
                return (this.nota1 + this.nota2) / 2; 
            }
            else
            {
                return 2; 
            }
        }
    }
}
