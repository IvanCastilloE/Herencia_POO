using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Carlos" , 38);
            persona1.Saludar();

            Empleado empleado1 = new Empleado("Alfonso", 18, "Lider", 5000);
            empleado1.Saludar();
            Console.ReadKey();


        }
    }
}
