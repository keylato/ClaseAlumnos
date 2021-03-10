using System;
using System.Collections.Generic;

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

            //materias

            Materia programacion1 = new Materia ("Programacion 1", 2);
            Console.WriteLine("La materia de" + programacion1.nombre + "se ve en" + programacion1.NombreSemestre);

            Materia inteligenciaArtificial = new Materia ("Programacion 1", 2);
            Console.WriteLine("La materia de" + inteligenciaArtificial.nombre + "se ve en" + inteligenciaArtificial.NombreSemestre);

            //listas

            List<Materia> materiasDeInteres = new List<Materia>();
            materiasDeInteres.Add(programacion1);
            materiasDeInteres.Add(inteligenciaArtificial);
            materiasDeInteres.Add(new Materia("sistemas interactivos i",7));

            Console.WriteLine("La materia de" + materiasDeInteres[2].nombre + "Se ve en" + materiasDeInteres[2].semestre);
            Console.WriteLine("Me interesan " + materiasDeInteres.Count + "materias");

            for(int i = 0; i < materiasDeInteres.Count; i++)
            {
                Console.WriteLine(materiasDeInteres[i].nombre);
            }


            



        }


    }
}
