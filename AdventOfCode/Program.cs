using System;

namespace AdventOfCode
{
    class Program
    {
        public static void Main()
        {
            string numbers = "0123456789";
            string[] lines = File.ReadAllLines(@"..\..\..\Files\texto.txt");

            int solution = GetNumbers(lines, numbers);

            Console.WriteLine(solution);
        }

        public static int GetNumbers(string[] linea, string numbers)
        {
            string numbersSolution = "";
            int sum = 0;

            bool firstNum;
            bool lastNum;

            foreach (string line in linea)
            {
                firstNum = false;
                lastNum = false;

                int j = 0;

                while (!firstNum)
                {
                    if (numbers.Contains(line[j]))
                    {
                        numbersSolution += line[j];
                        firstNum = true;
                    }
                    j++;
                }

                j = line.Length - 1;

                while (!lastNum)
                {
                    if (numbers.Contains(line[j]))
                    {
                        numbersSolution += line[j];
                        lastNum = true;
                    }
                    j--;
                }

                sum += Convert.ToInt32(numbersSolution);
                numbersSolution = "";
            }

            return sum;
        }
    }
}