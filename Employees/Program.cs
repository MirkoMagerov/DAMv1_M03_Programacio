using Employees;

namespace Program
{
    public class MyClass
    {
        public static void Main()
        {
            Partner partner = new Partner("Magerov", "Miroslav", 5, 5, 10);
            DateTime fechaNacimiento = new DateTime(2005, 4, 30);

            Console.WriteLine(partner.GetAge(fechaNacimiento));
        }
    }
}