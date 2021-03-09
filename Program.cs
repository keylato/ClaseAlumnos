using System;

namespace Alumnos
{
    class program
    {
        public static void Main(string[] args)
        {
            Persona persona1 = new Persona("Miguel", "Mendoza");
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentacion();

            persona1.apellido = "Mendoza";
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentacion();

            persona1.colorFavorito = "rosa";

            Console.WriteLine(persona1.colorFavorito);

            //alumnos

            Alumno Toribio = new Alumno("Toribio", "Perez", 2106);
            Console.WriteLine("Primer alumno: " + Toribio.NombreCompleto);
            Toribio.Presentarse();



        }


    }
}
