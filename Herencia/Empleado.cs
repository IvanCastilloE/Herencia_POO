﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Empleado: Persona
    {
        public string Puesto { get; set; }
        public decimal Sueldo { get; set; }

        public Empleado(string nombre, int edad, string puesto, decimal sueldo) : base(nombre, edad)
        {
            Puesto = puesto;
            Sueldo = sueldo;
        }

        public override void Saludar()
        {
            Console.WriteLine("Hola, soy {0} y mi puesto es {1}", Nombre, Puesto);
        }
        public override string ToString() 
        {
            return string.Format("{0}, {1} años, {2}, sueldo: ${3}", Nombre, Edad, Puesto, Sueldo);
        }
    }
}
