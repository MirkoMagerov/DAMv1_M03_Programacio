using System;
using System.Text.RegularExpressions;

namespace OOP
{
    public class Program
    {
        public static void Main()
        {
            DateTime dateTime = new DateTime(2023,9,12);
            IDictionary<string, double> employeesValues = new Dictionary<string, double>();

            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();

            employeesValues.Add(employee1.Nom, employee1.GetAnnualSalary());
            employeesValues.Add(employee2.Nom, employee2.GetAnnualSalary());
            employeesValues.Add(employee3.Nom, employee3.GetAnnualSalary());

            // EX 11
            //foreach (KeyValuePair<string,double> employee in employeesValues)
            //{
            //    Console.WriteLine($"Nombre: {employee.Key} | Salario Anual: {employee.Value}");
            //}

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
            employees.Add(employee5);

            List<SalesEmployee> salesEmployees = new List<SalesEmployee>();
            salesEmployees.Add(salesEmployee1);
            salesEmployees.Add(salesEmployee2);
            salesEmployees.Add(salesEmployee3);
            salesEmployees.Add(salesEmployee4);
            salesEmployees.Add(salesEmployee5);

            employees.Sort();
            salesEmployees.Sort();

            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //}

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(CalculateListSumNumbers(numbers));

            //Console.WriteLine();
            //List<int> evenNums = GetEvenNumbers(numbers);
            //foreach (int i in evenNums) Console.WriteLine(i);

            //string[] strs = { "aa", "bb", "cc", "ee" };
            //List<string> strings = ConvertArrayToList(strs);
            //foreach (string str in strings) Console.WriteLine(str);

            //string check1 = "elab";
            //string check2 = "ela";
            //string check3 = "eaaabb";
            //string emailAdress = "miroslav.magerov.7e5@gmail.com";

            //Console.WriteLine(NotSpecialChars(check1));
            //Console.WriteLine(BLetterAfterA(check3));
            //Console.WriteLine(ALetterBeforeMoreThanOneB(check2));
            //Console.WriteLine(CheckEmailAdress(emailAdress));
        }

        // EX 3
        private static int CalculateDayTimePassed(DateTime userDate)
        {
            TimeSpan daysPassed;
            DateTime todayFullDate = DateTime.Today;

            if (userDate > todayFullDate)
            {
                Console.WriteLine("La fecha no puede ser posterior a la fecha de hoy");
                return 0;
            }

            daysPassed = todayFullDate - userDate;

            return daysPassed.Days;
        }

        // EX 4
        private static string GetForwardDate(DateTime firstDate, DateTime secondDate)
        {
            if (firstDate >= secondDate)
                return "La segunda fecha es anterior o igual a la primera.";

            else
                return "La segunda fecha es posterior a la primera.";
        }

        // EX 5
        private static string GetTodayDay()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.DayOfWeek.ToString();
        }

        // EX 8
        private static double CalculateListSumNumbers<T>(List<T> numbers)
        {
            double sum = numbers.Sum(x => Convert.ToDouble(x));
            return sum;
        }

        // EX 9
        private static List<T> GetEvenNumbers<T>(List<T> numbers)
        {
            return numbers.Where(x => Convert.ToDouble(x) % 2 == 0).ToList();
        }

        // EX 10
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

            Regex pattern = new Regex(@"^[a-zA-Z0-9]*$");
            
            return pattern.IsMatch(str);
        }

        // b
        private static bool BLetterAfterA(string str)
        {
            if (str == null) return false;
            if (str.Length == 0) return false;

            Regex pattern = new Regex(@"[aA]|[aA][bB]");

            return pattern.IsMatch(str);
        }

        // c
        private static bool ALetterBeforeMoreThanOneB(string str)
        {
            if (str == null) return false;
            if (str.Length == 0) return false;

            Regex pattern = new Regex(@"[aA][bB]{2,3}");

            return pattern.IsMatch(str);
        }

        // d
        private static bool CheckEmailAdress(string str)
        {
            if (str == null) return false;
            if (str.Length == 0) return false;

            Regex pattern = new Regex(@"^[a-zA-Z0-9._%+&$·!-]+@gmail\.com$");

            return pattern.IsMatch(str);
        }
    }
}