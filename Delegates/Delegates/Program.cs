using System;
using System.Collections.Generic;
using Delegates;

namespace Delegates
{
    public class Program
    {
        static void Main()
        {
            Helper helper = new Helper();
            Delegates.TwoIntsDelegator comparadorDeInts = Helper.CompararInts;
            Delegates.TwoIntsDelegator calculadorDePotencias = Helper.CalcularPotencia;
            Delegates.DoubleUniqueDelegator calculadorDeRaices = Helper.CalcularRaizCuadrada;
            Delegates.DoubleIntArrayDelegator calculadorDeMedia = Helper.CalcularMedia;
            Delegates.EvenNumber evenNumber = Helper.IsEven;
            Delegates.OnlyOneInt fibonacci = Helper.Fibonacci;

            List<int> intsList = new List<int>();
            intsList.Add(3);
            intsList.Add(1);
            intsList.Add(4);
            intsList.Add(5);
            intsList.Add(2);

            Console.WriteLine("----------- EX 18 -----------");
            intsList.Sort((x, y) => comparadorDeInts(x, y));
            Helper.PrintIntList(intsList);
            Console.WriteLine();

            Console.WriteLine("----------- EX 19 -----------");
            Console.WriteLine(calculadorDePotencias(3,3));
            Console.WriteLine();

            Console.WriteLine("----------- EX 20 -----------");
            Console.WriteLine(calculadorDeRaices(20));
            Console.WriteLine();

            Console.WriteLine("----------- EX 21 -----------");
            Console.WriteLine(calculadorDeMedia([3,5,7,1,2,4]));
            Console.WriteLine();

            Console.WriteLine("----------- EX 22 -----------");
            evenNumber(2);
            Console.WriteLine();

            Console.WriteLine("----------- EX 23 -----------");
            Console.WriteLine(fibonacci(5));
            Console.WriteLine();

            Console.WriteLine("----------- EX 25 -----------");
            Console.WriteLine(Identifier.Clean("my   Id"));
            Console.WriteLine(Identifier.Clean("my\0Id"));
            Console.WriteLine(Identifier.Clean("a-bc"));
            Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
            Console.WriteLine(Identifier.Clean("MyOβιεγτFinder"));
            Console.WriteLine(Identifier.Clean("9 -abcĐ😀ω\0"));
            Console.WriteLine();

            Console.WriteLine("----------- EX 26 -----------");
            List<int> prueba26 = Helper.GetEvenNumsWithLinq([1,5,2,4,9,8,10,3]);
            foreach(int num in prueba26)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("----------- EX 27 -----------");
            List<int> prueba27 = Helper.GetPositiveNumbersWithLinq([1, -5, 2, 4, -9, 8, -10, 3]);
            foreach(int num in prueba27)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("----------- EX 28 -----------");
            List<int> prueba28 = Helper.GetBiggerThan20([6,21,30,18,20,71,30,15]);
            foreach(int num in prueba28)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();
            Console.WriteLine("----------- EX 29 -----------");
            Helper.GetFrequenceNumber([1, 4, 2, 3, 3, 8, 10, 3], 3);
            Console.WriteLine();

            Console.WriteLine("----------- EX 30 -----------");
            Helper.GetFrequenceCharacter("abadakedabramadafaka");
            Console.WriteLine();

            Console.WriteLine("----------- EX 31 -----------");
            Helper.WeekDays();
            Console.WriteLine();

            Console.WriteLine("----------- EX 32 -----------");
            List<int> prueba32 = Helper.EjercicioRaro([1,2,3,4,5,1,1,2,3,4,5]);
            foreach(int num in prueba32)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Console.WriteLine("----------- EX 33 -----------");
            Helper.CheckForWord(["ROMA","LONDRES","NAIROBI","CALIFÒRNIA","ZURICH","NOVA DELHI","AMSTERDAM","ABU DHABI","PARÍS"]);
            Console.WriteLine();

            Console.WriteLine("----------- EX 34 -----------");
            //Helper.PedirNumeritos();
            Console.WriteLine();

            Console.WriteLine("----------- EX 35 -----------");
            Helper.EncontrarImpostores("this IS a STRING");
            Console.WriteLine();
        }
    }
}