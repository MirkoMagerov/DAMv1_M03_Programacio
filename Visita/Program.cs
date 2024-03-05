namespace Program
{
    public class MyClass
    {
        public static void Main()
        {
            Propietari primerPropietario = new Propietari("31922222E","Manolo",606060606);
            Pacient primerPaciente = new Pacient("Pice", "Gato blanco-gris", 8, true);
            DateTime fecha = new DateTime();

            Visita primeraVisita = new Visita(primerPaciente, primerPropietario, fecha, "Motivo 1");
            Visita segundaVisita = new Visita(primerPaciente, primerPropietario, fecha, "Motivo 2");
            Visita terceraVisita = new Visita(primerPaciente, primerPropietario, fecha, "Motivo 3");
            Visita cuartaVisita = new Visita(primerPaciente, primerPropietario, fecha, "Motivo 4");
            Visita quintaVisita = new Visita(primerPaciente, primerPropietario, fecha, "Motivo 5");

            Console.WriteLine(Visita.Encabezado());
            Console.WriteLine(primeraVisita.ToString());
            Console.WriteLine(segundaVisita.ToString());
            Console.WriteLine(terceraVisita.ToString());
            Console.WriteLine(cuartaVisita.ToString());
            Console.WriteLine(quintaVisita.ToString());
        }

        // EX 3
        public static int CalculateDayTimePassed(DateTime userDate)
        {
            TimeSpan daysPassed;
            DateTime todayFullDate = DateTime.Today;

            if (userDate > todayFullDate)
            {
                throw new Exception("La fecha no puede ser posterior a la fecha de hoy");
            }

            daysPassed = todayFullDate - userDate;

            return daysPassed.Days;
        }

        // EX 4
        public static string GetForwardDate(DateTime firstDate, DateTime secondDate)
        {
            if (firstDate >= secondDate)
                return "La segunda fecha es anterior o igual a la primera.";

            else
                return "La segunda fecha es posterior a la primera.";
        }

        // EX 5
        public static string GetTodayDay()
        {
            return new DateTime().DayOfWeek.ToString();
        }
    }
}