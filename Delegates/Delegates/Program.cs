using System;
using System.Collections.Generic;

namespace Delegates
{
    public class Program
    {
        static void Main()
        {
            Delegates.TwoIntsDelegator comparadorDeInts = Helper.CompararInts;
            Delegates.TwoIntsDelegator calculadorDePotencias = Helper.CalcularPotencia;
            Delegates.DoubleUniqueDelegator calculadorDeRaices = Helper.CalcularRaizCuadrada;
            Delegates.DoubleIntArrayDelegator calculadorDeMedia = Helper.CalcularMedia;

            List<int> intsList = new List<int>();
            intsList.Add(3);
            intsList.Add(1);
            intsList.Add(4);
            intsList.Add(5);
            intsList.Add(2);

            intsList.Sort((x,y) => comparadorDeInts(x,y));

            Console.WriteLine("----------- EX 18 -----------");
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
        }
    }
}