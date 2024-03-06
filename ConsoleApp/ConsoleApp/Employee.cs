using System;

namespace OOP
{
    public class Employee : IComparable<Employee>
    {
        public string Cognom { get; set; }
        public string Nom { get; set; }
        public string Codi { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public float MonthSalary { get; set; }
        public int Payments { get; set; }
        public static int employeeCount;

        public Employee(string cognom, string nom, string codi, DateTime birthDate, DateTime hireDate, float monthSalary = 1800, int payments = 18)
        {
            Cognom = cognom;
            Nom = nom;
            Codi = codi;
            BirthDate = birthDate;
            HireDate = hireDate;
            MonthSalary = monthSalary;
            Payments = payments;
            employeeCount++;
        }

        public Employee() : this("Apellido" + employeeCount, "Nombre" + employeeCount, "Codigo" + employeeCount, GenerateRandomHireDate(), GenerateRandomHireDate())
        {

        }

        public string GetNameAndSurname()
        {
            return $"Nombre: {Nom}, Apellido: {Cognom}";
        }

        public string GetSurnameAndName()
        {
            return $"Apellido: {Cognom}, Nombre: {Nom}";
        }

        public string GetAntiquity()
        {
            DateTime today = DateTime.Today;
            TimeSpan timeSpan = today - HireDate;
            return $"Años de antigüedad: {timeSpan.Days / 365}";
        }

        public virtual float GetAnnualSalary()
        {
            return MonthSalary * Payments;
        }

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

        public override string ToString()
        {
            return  $"---------------------------\n" +
                    $"          EMPLOYEE         \n" +
                    $"---------------------------\n" +
                    $"> Code : {Codi}\n" +
                    $"> Last Name: {Cognom}\n" +
                    $"> First Name: {Nom}\n" +
                    $"> Birth Date: {BirthDate.ToShortDateString()}\n" +
                    $"> Hire Date: {HireDate.ToShortDateString()}\n" +
                    $"> Monthly Salary: {MonthSalary}\n" +
                    $"> Payments: {Payments}\n";
        }
        public int CompareTo(Employee? other)
        {
            if (other == null) return 0;
            return -this.GetAntiquity().CompareTo(other.GetAntiquity());
        }

        private static DateTime GenerateRandomHireDate()
        {
            Random rnd = new Random();
            int year = rnd.Next(2010, 2021);
            int month = rnd.Next(1, 13);
            int day = rnd.Next(1, DateTime.DaysInMonth(year, month) + 1);
            return new DateTime(year, month, day);
        }
    }
}