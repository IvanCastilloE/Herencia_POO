using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Persona
    {
        public string Nombre { get; set; } //Auto properties o propiedades automaticas
        public int Edad { get; set; }

        public Persona() { } //Constructor vacio

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public virtual void Saludar() //Metodo saludar va poder ser sobre escrito por futuras subclases
        {
            Console.WriteLine("Hola mi nombre es {0}", Nombre);
        }

        public override string ToString() //Override nos ayuda a sobreeescribir la clase ToString para personalizar la funcion
        {
            return string.Format("{0}, {1} años", Nombre, Edad);
        }

    }
}
