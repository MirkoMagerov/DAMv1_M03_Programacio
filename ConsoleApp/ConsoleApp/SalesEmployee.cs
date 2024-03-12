using System.Text;

namespace OOP
{
    public class SalesEmployee : Employee
    {
        public float Commission { get; set; }

        public SalesEmployee(string cognom, string nom, string codi, DateTime birthDate, DateTime hireDate, float commission, float monthSalary = 1800, int payments = 14) 
            : base(cognom, nom, codi, birthDate, hireDate, monthSalary, payments)
        {
            Commission = commission;
        }

        public SalesEmployee() : this("Apellido", "Nombre", "Codigo", DateTime.MinValue, DateTime.MinValue, commission:3.5f)
        {

        }

        public override float GetAnnualSalary()
        {
            return MonthSalary + (MonthSalary * Commission / 100);
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("---------------------------\n");
            stringBuilder.Append("      SALES EMPLOYEE       \n");
            stringBuilder.Append("---------------------------\n");
            stringBuilder.Append($"> Code : {Codi}\n");
            stringBuilder.Append($"> Last Name: {Cognom}\n");
            stringBuilder.Append($"> First Name: {Nom}\n");
            stringBuilder.Append($"> Birth Date: {BirthDate.ToShortDateString()}\n");
            stringBuilder.Append($"> Hire Date: {HireDate.ToShortDateString()}\n");
            stringBuilder.Append($"> Monthly Salary: {MonthSalary}\n");
            stringBuilder.Append($"> Payments: {Payments}\n");
            stringBuilder.Append($"> Commission: {Commission}\n");

            string result = stringBuilder.ToString();
            return result;
        }
    }
}
