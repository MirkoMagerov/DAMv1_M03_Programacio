using System.Diagnostics.Tracing;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Delegates
{
    public class Helper
    {
        public static void PrintIntList(List<int> list)
        {
            foreach(int x in list)
            {
                Console.WriteLine(x);
            }
        }

        public static int CompararInts(int a, int b)
        {
            return a.CompareTo(b);
        }

        public static int CalcularPotencia(int a, int b)
        {
            return Convert.ToInt32(Math.Pow(a, b));
        }

        public static double CalcularRaizCuadrada(int a)
        {
            return Math.Round(Math.Sqrt(a),4);
        }

        public static double CalcularMedia(int[] numeros)
        {
            int suma = 0;
            foreach(int num in numeros)
            {
                suma += num;
            }
            return Math.Round(Convert.ToDouble(suma) / numeros.Length,3);
        }

        public static int Fibonacci(int num)
        {
            if (num <= 1) return num;

            int prev = 0;
            int curr = 1;

            for (int i = 2; i <= num; i++)
            {
                int temp = curr;
                curr += prev;
                prev = temp;
            }

            return curr;
        }

        public static void IsEven(int num)
        {
            Console.WriteLine(num % 2 == 0 ? num * 2 : $"El número {num} és senar.");
        }

        // EX 26
        public static List<int> GetEvenNumsWithLinq(List<int> nums)
        {
            var evens = from num in nums where num % 2 == 0 select num;

            return evens.ToList();
        }

        // EX 27
        public static List<int> GetPositiveNumbersWithLinq(List<int> nums)
        {
            var evens = from num in nums where num > 0 select num;

            return evens.ToList();
        }

        // EX 28
        public static List<int> GetBiggerThan20(List<int> nums)
        {
            var evens = from num in nums where num > 0 select num;
            List<int> result = new List<int>();

            foreach(int i in evens)
            {
                result.Add(i);
                result.Add(i * i);
            }

            return result;
        }

        // EX 29
        public static void GetFrequenceNumber(List<int> nums, int number)
        {
            int counter = (from n in nums 
                           where n == number
                           select n).Count();

            Console.WriteLine($"El número {number} aparace {counter} veces en la lista.");
        }

        // EX 30
        public static void GetFrequenceCharacter(string text)
        {
            List<char> chars = new List<char>();
            foreach(char ch in text)
            {
                if (!chars.Contains(ch))
                {
                    int counter = (from c in text
                                   where c == ch
                                   select c).Count();

                    Console.WriteLine($"El carácter {ch} aparece {counter} veces en el texto {text}.");
                    chars.Add(ch);
                }
            }
        }

        // EX 31
        public static void WeekDays()
        {
            List<int> days = [ 0, 1, 2, 3, 4, 5, 6 ];
            var daysToText = from num in days
                             select (DayOfWeek)num;

            foreach(DayOfWeek day in daysToText)
            {
                Console.WriteLine(day);
            }
        }

        // EX 32
        public static List<int> EjercicioRaro(List<int> nums)
        {
            List<int> listaRara = new List<int>();
            foreach (int num in nums)
            {
                if (!listaRara.Contains(num))
                {
                    int counter = (from c in nums
                                   where c == num
                                   select c).Count();

                    listaRara.Add(counter);
                    listaRara.Add(counter * num);
                }
            }

            return listaRara;
        }

        // EX 33
        public static void CheckForWord(List<string> words)
        {
            
            var passedWords = from word in words
                              where word[0] == 'A' && word[^1] == 'M'
                              select word;

            Console.Write($"Palabras que cumplen el filtro: ");
            foreach (string passedWord in passedWords)
            {
                Console.Write(passedWord + " ");
            }
        }

        // EX 34
        public static void PedirNumeritos()
        {
            const int MaxNumeros = 5;
            List<int> numbers = new List<int>();
            for(int i = 0; i < MaxNumeros; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }

            var mayoresA80 = from num in numbers
                             where num > 80
                             select num;

            Console.WriteLine("Numeros mayores a 80: ");

            foreach (int num in mayoresA80)
            {
                Console.WriteLine(num);
            }
        }

        // EX 35
        public static void EncontrarImpostores(string text)
        {
            string[] wordsSeparated = text.Split(" ");
            var mayusculas = from word in wordsSeparated
                             where word.Equals(word.ToUpper())
                             select word;

            foreach(string word in mayusculas)
            {
                Console.WriteLine(word);
            }
        }
    }
}
