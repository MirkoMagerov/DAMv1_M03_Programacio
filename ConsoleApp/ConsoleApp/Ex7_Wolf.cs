using System;

namespace OOP
{
    public class Ex7_Wolf : Ex7_AAnimal
    {
        // Ex7_Wolf loboGris = new Ex7_Wolf("Lobo Gris", "Mamífero", "Carnívoro", 5, 12, "Bosques", "Gris", true);

        string? colorPelaje;
        bool liderManada;

        public Ex7_Wolf(string nombreTecnico, string tipoReproduccion, string tipoDieta, int age, int expectedAge, string biomasHabitables, string colorPelaje, bool liderManada) : base(nombreTecnico, tipoReproduccion, tipoDieta, age, expectedAge, biomasHabitables)
        {
            NombreTecnico = nombreTecnico;
            TipoReproduccion = tipoReproduccion;
            TipoDieta = tipoDieta;
            Age = age;
            ExpectedAge = expectedAge;
            BiomasHabitables = biomasHabitables;
            ColorPelaje = colorPelaje;
            LiderManada = liderManada;
        }

        public string ColorPelaje
        {
            get { return colorPelaje; }
            set { colorPelaje = value; }
        }

        public bool LiderManada
        {
            get { return liderManada; }
            set { liderManada = value; }
        }

        public void Cazar()
        {
            Console.WriteLine(base.NombreTecnico + " está cazando.");
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
