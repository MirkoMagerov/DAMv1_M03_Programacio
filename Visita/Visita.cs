using System;
using System.Reflection.PortableExecutable;

namespace Program
{
    public class Visita
    {
        public Pacient Paciente { get; set; }
        public Propietari Propietario { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        private int _id;
        private static int _idCounter = 0;

        public Visita(Pacient pacient, Propietari propietari, DateTime fecha, string motivo)
        {
            Paciente = pacient;
            Propietario = propietari;
            Fecha = fecha;
            Motivo = motivo;
            _idCounter++;
            _id = _idCounter;
        }

        public override int GetHashCode()
        {
            return Paciente.Edad * Propietario.Telefono + _id;
        }

        public static string Encabezado()
        {
            return $"{"Propietario",-12} | {"Paciente",-12} | {"Fecha",-18} | {"Motivo",-12}\n";
        }

        public override string ToString()
        {
            // Línea separadora
            string separatorForColumn = new string('-', 62) + "\n";

            // Valores de los atributos
            string values = $"{this.Propietario.Name,-12} | {this.Paciente.Nombre,-12} | {this.Fecha,-18} | {this.Motivo,-12}\n";

            return separatorForColumn + values;
        }
    }
}
