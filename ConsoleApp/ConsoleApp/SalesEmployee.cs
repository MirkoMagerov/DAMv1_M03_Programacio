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
            return base.ToString() + $"> Commission: {Commission}\n";
        }
    }
}
