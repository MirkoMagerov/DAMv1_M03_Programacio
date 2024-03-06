using System;
using System.Text.RegularExpressions;

namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            IDictionary<string, double> employeesValues = new Dictionary<string, double>();

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();

            employeesValues.Add(employee1.Nom, employee1.GetAnnualSalary());
            employeesValues.Add(employee2.Nom, employee2.GetAnnualSalary());
            employeesValues.Add(employee3.Nom, employee3.GetAnnualSalary());

            foreach(KeyValuePair<string, double> kvp in employeesValues)
            {
                Console.WriteLine($"EMPLEADO: {kvp.Key} | SALARIO: {kvp.Value}");
            }

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

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] strs = { "aa", "bb", "cc", "ee" };
            Console.WriteLine(CalculateListSumNumbers(numbers));
            Console.WriteLine();
            List<int> evenNums = GetEvenNumbers(numbers);
            foreach (int i in evenNums) Console.WriteLine(i);
            List<string> strings = ConvertArrayToList(strs);
            foreach (string str in strings) Console.WriteLine(str);
        }

        private static double CalculateListSumNumbers<T>(List<T> numbers)
        {
            double sum = numbers.Sum(x => Convert.ToDouble(x));
            return sum;
        }

        private static List<T> GetEvenNumbers<T>(List<T> numbers)
        {
            return numbers.Where(x => Convert.ToDouble(x) % 2 == 0).ToList();
        }

        private static List<String> ConvertArrayToList(string[] array)
        {
            List<String> list = new List<String>();
            foreach (string str in array)
            {
                list.Add(str);
            }
            return list;
        }

        // 14
        // a
        private static bool NotSpecialChars(string str)
        {
            if (str == null) return false;
            if (str.Length == 0) return false;

            Regex pattern = new Regex(@"[^a-zA-Z0-9]");
            
            return !pattern.IsMatch(str);
        }

        // b
        private static bool BLetterAfterA(string str)
        {
            if (str == null) return false;
            if (str.Length == 0) return false;

            Regex pattern = new Regex(@"[aA]|[aA][bB]");

            return !pattern.IsMatch(str);
        }
    }
}