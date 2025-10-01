using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF01ACTIVIDAD1
{
    public enum EstadoCivil
    {
        SOLTERO,
        CASADO
    }
    public class Persona
    {
        public string Nombre;
        public int Edad;
        public EstadoCivil EstadoCivil;

        public Persona(string nombre, int edad, EstadoCivil eCivil)
        {
            Nombre = nombre;
            Edad = edad;
            EstadoCivil = eCivil;
        }
    }
}
