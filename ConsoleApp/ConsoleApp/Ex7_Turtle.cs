using System;

namespace OOP
{
    public class Ex7_Turtle : Ex7_AAnimal
    {
        // Ex7_Turtle tortugaOvipara = new Ex7_Turtle("Tortuga", "Ovípara", "Herbívora", 5, 50, "Húmedos", "Duro", true);

        string? tipoCaparazon;
        bool puedeNadar;

        public Ex7_Turtle(string nombreTecnico, string tipoReproduccion, string tipoDieta, int age, int expectedAge, string biomasHabitables, string tipoCaparazon, bool puedeNadar) : base(nombreTecnico, tipoReproduccion, tipoDieta, age, expectedAge, biomasHabitables)
        {
            NombreTecnico = nombreTecnico;
            TipoReproduccion = tipoReproduccion;
            TipoDieta = tipoDieta;
            Age = age;
            ExpectedAge = expectedAge;
            BiomasHabitables = biomasHabitables;
            TipoCaparazon = tipoCaparazon;
            PuedeNadar = puedeNadar;
        }

        public string TipoCaparazon
        {
            get { return tipoCaparazon; }
            set { tipoCaparazon = value; }
        }

        public bool PuedeNadar
        {
            get { return puedeNadar; }
            set { puedeNadar = value; }
        }

        public void Nadar()
        {
            if (PuedeNadar)
            {
                Console.WriteLine(base.NombreTecnico + " está nadando.");
            }
            else
            {
                Console.WriteLine(base.NombreTecnico + " no puede nadar.");
            }
        }

        public override void Eat()
        {
            Console.WriteLine(NombreTecnico + " está comiendo.");
        }

        public override void Sleep()
        {
            Console.WriteLine(NombreTecnico + " está durmiendo.");
        }

        public override void Reproduce()
        {
            Console.WriteLine(NombreTecnico + " se está reproduciendo.");
        }
    }
}
