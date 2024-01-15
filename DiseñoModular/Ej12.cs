/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici 12.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // CÓDIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterQuantity = "Introduce la cantidad de litros de agua: ";
            const double LowerThan200 = 0.1, BiggerThan200 = 0.3, FixedFee = 6;

            int literQuantity;

            double finalPrice = FixedFee;

            Console.Write(MsgEnterQuantity);
            literQuantity = Convert.ToInt32(Console.ReadLine());

            finalPrice += LowPriceQuantity(LowerThan200, literQuantity) + HighPriceQuantity(BiggerThan200, literQuantity);

            Console.WriteLine(Math.Round(finalPrice, 1));
        }

        public static double LowPriceQuantity(double price, double literQuantity)
        {
            if (literQuantity > 200)
            {
                literQuantity = 150;
            }
            else
            {
                literQuantity -= 50;
            }

            return literQuantity * price;
        }

        public static double HighPriceQuantity(double price, double literQuantity)
        {
            if (literQuantity > 200)
            {
                literQuantity -= 200;
            }
            else
            {
                literQuantity = 0;
            }

            return literQuantity * price;
        }
    }
}