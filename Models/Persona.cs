using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _00_ProyectoBase.Interfaces;

namespace _00_ProyectoBase
{
    public abstract class Persona : IPersona
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"{Nombre} {Apellido} - {Edad} años";
        }

        public void Comer()
        {
            Console.WriteLine("Comer");
        }

        public abstract void Dormir();
    }
}