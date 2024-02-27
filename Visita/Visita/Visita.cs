using System;

namespace Program
{
    public class Visita
    {
        public Pacient Paciente { get; set; }
        public Propietari Propietario { get; set; }
        public DateOnly Fecha { get; set; }
        public string Motivo { get; set; }
        private int _id;
        private static int _idCounter = 0;

        public Visita(Pacient pacient, Propietari propietari, DateOnly fecha, string motivo)
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

        public override string ToString()
        {
            // Encabezados de la tabla
            string headers = $"{"Propietario",-12} | {"Paciente",-12} | {"Fecha",-12} | {"Motivo",-12}\n";

            // Línea separadora
            string separatorForColumn = new string('-', 62) + "\n";

            // Valores de los atributos
            string values = $"{this.Propietario.Name,-12} | {this.Paciente.Nombre,-12} | {this.Fecha,-12} | {this.Motivo,-12}\n";

            return headers + separatorForColumn + values;
        }
    }
}
