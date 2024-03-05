using System;

namespace Program
{
    public class Propietari
    {
        public string Dni { get; set; }
        public string Name { get; set; }
        public int Telefono { get; set; }

        public Propietari(string dni, string name, int telefono)
        {
            Dni = dni;
            Name = name;
            Telefono = telefono;
        }
    }
}
