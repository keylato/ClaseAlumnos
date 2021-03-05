using System;

namespace Alumnos
{
    class program
    {
        public static void Main(string[] args)
        {
            Personas persona1 = new Personas("Miguel", "Mendoza");
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentacion();

            persona1.apellido = "Mendoza";
            Console.WriteLine(persona1.NombreCompleto);
            persona1.Presentacion();

            persona1.colorFavorito= "rosa";

            Console.WriteLine(persona1.colorFavorito);

        }


    }
}
