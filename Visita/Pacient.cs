using System;

namespace Program
{
    public class Pacient
    {
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public bool Vacunado { get; set; }

        public Pacient(string nombre, string raza, int edad, bool vacunado)
        {
            this.Nombre = nombre;
            this.Raza = raza;
            this.Edad = edad;
            this.Vacunado = vacunado;
        }
    }
}
