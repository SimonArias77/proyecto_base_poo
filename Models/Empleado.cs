using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _00_ProyectoBase.Interfaces;

namespace _00_ProyectoBase.Models
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }
        public double Sueldo { get; set; }

        public Empleado(string nombre, string apellido, int edad, string cargo, double sueldo)
        : base(nombre, apellido, edad)
        {
            Cargo = cargo;
            Sueldo = sueldo;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre}, Apellido: {Apellido}, Edad: {Edad}, Cargo: {Cargo}, Sueldo: {Sueldo}";
        }

        public override void Dormir()
        {
            throw new NotImplementedException();
        }
    }
}