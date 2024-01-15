/*En l�estudi on est�s fent les pr�ctiques, volen llen�ar un nou videojoc. Les tasques que t�han assignat s�n crear les rutines seg�ents que s�afegiran al programa que est� 
implementant tot l�equip:
Demanar a l�usuari el nom del personatge amb el que vol jugar. La rutina ha de validar que el nom no superi els 10 car�cters.
Demanar a l�usuari que introdueixi un nombre dins del rang [1,500].
Generar un valor aleatori (posici� del mapa) entre el 1 i el 100.*/

using System;
namespace Activitats
{
    public class ej31
    {
        public static void Main()
        {
            const string MsgName = "Introdueix el nom d'usuari: ";
            const string MsgNumRange = "Introdueix un nombre dins del rang [1, 500]: ";
            const string MsgRandom = "El valor aleatori �s: ";

            string name = "";
            int number = 0;

            Random rand = new Random();


            do
            {
                Console.WriteLine(MsgName);
                name = Console.ReadLine();
            } while (!validarNom(name));
            Console.WriteLine(name);

            do
            {
                Console.WriteLine(MsgNumRange);
                number = Convert.ToInt32(Console.ReadLine());
            } while (number < 1 || number > 500);
            Console.WriteLine(number);

            Console.WriteLine(MsgRandom);
            Console.WriteLine(generarRandom(rand));
        }

        public static bool validarNom(string name)
        {
            if (name.Length > 10) return false;
            else return true;
        }

        public static bool validarRang(int number)
        {
            if (number < 1 && number > 500) return false;
            else return true;
        }

        public static int generarRandom(Random rand)
        {
            return rand.Next(1, 100);

        }
    }
}