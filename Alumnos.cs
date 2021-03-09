using System;

namespace Alumnos
{
    class Alumno: Persona
    {
        //(atributos heredados desde persona)
        public int matricula;
        static public string escuela = "Cresp";

        public Alumno(string nombre, string apellido, int matricula) : base (nombre, apellido)
            {
                this.matricula = matricula;
                
            }
        public void Presentarse()
        {
            Console.WriteLine($"Hola, mi nombres es {this.NombreCompleto} y soy estudiante en {Alumno.escuela} con matricula {this.matricula}");
        }
    }
}


