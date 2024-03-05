using System;

namespace Employees
{
    public abstract class Persona
    {
        protected string Cognom { get; set; }
        protected string Nom { get; set; }
        protected int Codi { get; set; }

        protected Persona(string cognom, string nom, int codi)
        {
            this.Cognom = cognom;
            this.Nom = nom;
            this.Codi = codi;
        }

        public abstract string Saludar(string nom, string cognom);

        // EX 6
        public virtual int GetAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (today.Month < birthDate.Month && today.Day < birthDate.Day)
            {
                age--;
            }

            return age;
        }
    }
}