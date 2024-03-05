using System;

namespace Employees
{
    public abstract class Employee
    {
        protected string Cognom { get; set; }
        protected string Nom { get; set; }
        protected string Codi { get; set; }
        protected DateTime BirthDate { get; set; }
        protected DateTime HireDate { get; set; }
        protected float MonthSalary { get; set; }
        protected int Payments { get; set; }
        protected int employeeCount;

        protected Persona(string cognom, string nom, int codi)
        {
            this.Cognom = cognom;
            this.Nom = nom;
            this.Codi = codi;
            employeeCount++;
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