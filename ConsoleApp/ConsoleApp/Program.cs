using System;

namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();

            SalesEmployee salesEmployee1 = new SalesEmployee();
            SalesEmployee salesEmployee2 = new SalesEmployee();
            SalesEmployee salesEmployee3 = new SalesEmployee();
            SalesEmployee salesEmployee4 = new SalesEmployee();
            SalesEmployee salesEmployee5 = new SalesEmployee();

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(salesEmployee5);

            List<SalesEmployee> salesEmployees = new List<SalesEmployee>();
            salesEmployees.Add(salesEmployee1);
            salesEmployees.Add(salesEmployee2);
            salesEmployees.Add(salesEmployee3);
            salesEmployees.Add(salesEmployee4);
            salesEmployees.Add(salesEmployee5);

            employees.Sort();
            salesEmployees.Sort();

            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
            }

            foreach(SalesEmployee salesEmployee in salesEmployees)
            {
                Console.WriteLine(salesEmployee);
            }
        }
    }
}