
using System;

namespace Alumnos
{

}
 class Personas
{

    public string name;
    public string apellido;

    public string NombreCompleto
    {
        get=> this.name + " "+ apellido;
    }

    private string ColorFavorito;

    public string colorFavorito
    {
        get => "color" + this.colorFavorito;

        set => this.colorFavorito = value;
    }


    public Personas(string name, string apellido)
    {
      
        this.name = name;
        this.apellido = apellido;
    }
    
    public void Presentacion ()
    {
        Console.WriteLine("Hola, me llamo" + name + apellido);
    
    }


}

