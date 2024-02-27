using System;

namespace OOP
{
    public class Ex7_Iguana : Ex7_AAnimal
    {
        // Ex7_Iguana iguana = new Ex7_Iguana("Iguana Común", "Ovovivípara", "Herbívora", 3, 15, "Selvas", true, 50);

        bool esVenenosa;
        int longitudCola;

        public Ex7_Iguana(string nombreTecnico, string tipoReproduccion, string tipoDieta, int age, int expectedAge, string biomasHabitables, bool esVenenosa, int longitudCola) : base(nombreTecnico, tipoReproduccion, tipoDieta, age, expectedAge, biomasHabitables)
        {
            NombreTecnico = nombreTecnico;
            TipoReproduccion = tipoReproduccion;
            TipoDieta = tipoDieta;
            Age = age;
            ExpectedAge = expectedAge;
            BiomasHabitables = biomasHabitables;
            EsVenenosa = esVenenosa;
            LongitudCola = longitudCola;
        }

        public bool EsVenenosa
        {
            get { return esVenenosa; }
            set { esVenenosa = value; }
        }

        public int LongitudCola
        {
            get { return longitudCola; }
            set { longitudCola = value; }
        }

        public void Camuflarse()
        {
            Console.WriteLine(base.NombreTecnico + " se está camuflando.");
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
