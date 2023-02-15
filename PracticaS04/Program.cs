using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS04
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Persona[] persona = new Persona[2];
            IPersona[] persona = new IPersona[2];
            persona[0] = new Alumno("Brandon Henriquez");
            persona[1] = new Empleado("Maria Rivas");

            for (int i = 0; i < persona.Length; i++)
            {
                //Console.WriteLine(persona[i].Saludar());
                Console.WriteLine(persona[i].Despedirse());
            }


        }
    }
}

public interface IPersona
{
    string Despedirse();
}



public abstract class Persona
{
    public string Nombre { get; set; }
    public abstract string Saludar();

}

public class Alumno : Persona, IPersona
{
    public Alumno(string nombre) 
    { 
        this.Nombre= nombre;
    }

    public string Despedirse()
    {
        string adios = "El alumno" + this.Nombre + " se despide cordialmente";
        return adios;
    }

    public override string Saludar()
    {
        string saludo = "Hola,mi nombre es: " + this.Nombre + " y soy un alumno";
        return saludo;
    }
}

public class Empleado : Persona, IPersona
{
    public Empleado(String nombre)
    {
        this.Nombre= nombre;
    }

    public string Despedirse()
    {
        string adios = "El empleado" + this.Nombre + " se despide cordialmente";
        return adios;
    }

    public override string Saludar()
    {
        string saludo = "Hola, mi nombre es: " + this.Nombre + " y soy un empleado";
        return saludo;
    }
}
