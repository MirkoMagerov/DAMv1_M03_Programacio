using System;

namespace OOP
{
    public abstract class Ex7_AAnimal
    {
        string ?nombreTecnico;
        string ?tipoReproduccion;
        string? tipoDieta;
        int age;
        int expectedAge;
        string ?biomasHabitables;

        public Ex7_AAnimal(string nombreTecnico, string tipoReproduccion, string tipoDieta, int age, int expectedAge, string biomasHabitables)
        {
            NombreTecnico = nombreTecnico;
            TipoReproduccion = tipoReproduccion;
            TipoDieta = tipoDieta;
            Age = age;
            ExpectedAge = expectedAge;
            BiomasHabitables = biomasHabitables;
        }

        public string NombreTecnico
        {
            get { return nombreTecnico; }
            set {  nombreTecnico = value; }
        }

        public string TipoReproduccion
        {
            get { return tipoReproduccion; }
            set { tipoReproduccion = value; }
        }

        public string TipoDieta
        {
            get { return tipoDieta; }
            set { tipoDieta = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int ExpectedAge
        {
            get { return expectedAge; } 
            set { expectedAge = value; }
        }

        public string BiomasHabitables
        {
            get { return biomasHabitables; }
            set { biomasHabitables = value; }
        }

        public abstract void Eat();

        public abstract void Sleep();

        public abstract void Reproduce();
    }
}
