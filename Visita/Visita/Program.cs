namespace Program
{
    public class MyClass
    {
        public static void Main()
        {
            Propietari primerPropietario = new Propietari("31922222E","Manolo",606060606);
            Pacient primerPaciente = new Pacient("Pice", "Gato blanco-gris", 8, true);
            DateOnly fecha = new DateOnly();
            string motivo = "Revisión general";

            Visita primeraVisita = new Visita(primerPaciente, primerPropietario, fecha, motivo);
            Visita segundaVisita = new Visita(primerPaciente, primerPropietario, fecha, "Motivo 2");

            Console.WriteLine(primeraVisita.ToString());
            Console.WriteLine(primeraVisita.GetHashCode());
            Console.WriteLine(segundaVisita.GetHashCode());
        }
    }
}