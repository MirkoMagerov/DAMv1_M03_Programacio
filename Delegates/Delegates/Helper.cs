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
    }
}
