/*
* Author: Miroslav Magerov
* M03. Programació UF2
* v1. dd/mm/aa
* Exercici X.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        public static void Main()
        {
            const string MsgPrimeraEstrofa = "{0} pometes té el pomer,\r\nde {0} una, de {0} una,\r\n{0} pometes té el pomer,\r\nde {0} una en caigué.\n";
            const string MsgSegundaEstrofa = "Si mireu el vent d'on ve,\r\nveureu el pomer com dansa,\r\nsi mireu el vent d'on ve,\r\nveure com dansa el pomer.";
            const string MsgPometes = "Escriu el número de pometes: ";

            int pometes;

            Console.Write(MsgPometes);
            pometes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(Pometes(pometes, MsgPrimeraEstrofa, MsgSegundaEstrofa));
        }

        public static int Pometes(int pometes, string primeraEstrofa, string segundaEstrofa)
        {
            if (pometes > 1)
            {
                MensajeEstrofa(pometes, primeraEstrofa, segundaEstrofa);
                return Pometes(pometes - 1, primeraEstrofa, segundaEstrofa);
            }
            else
            {
                return 0;
            }
        }

        public static void MensajeEstrofa(int pometes, string primeraEstrofa, string segundaEstrofa)
        {
            Console.WriteLine(primeraEstrofa, pometes);
            Console.WriteLine(segundaEstrofa);
            Console.WriteLine("\n-------------------------------\n");
        }
    }
}