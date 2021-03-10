
using System;

namespace Alumnos
{

}
 class Persona
{

    public string nombre;
    public string apellido;

    public string NombreCompleto
    {
        get=> this.nombre + " "+ apellido;
    }

    private string ColorFavorito;

    public string colorFavorito
    {
        get => "color" + this.colorFavorito;

        set => this.colorFavorito = value;
    }


    public Persona(string nombre, string apellido)
    {
      
        this.nombre = nombre;
        this.apellido = apellido;
    }
    
    public void Presentacion ()
    {
        Console.WriteLine("Hola, me llamo" + nombre + apellido);
    
    }


}


