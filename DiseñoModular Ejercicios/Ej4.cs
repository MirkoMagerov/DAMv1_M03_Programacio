/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 4.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgEnterText = "Introduce un texto: ";
            const string MsgUserElection = "Escribe 'mayus' para imprimirlo en may�sculas o 'minus' para imprimirlo en min�sculas: ";
            const string MsgConvertedText = "Texto convertido:";
            const string MsgWrongElection = "No has escrito bien el par�metro de conversi�n.";

            string userText, userElection;

            Console.Write(MsgEnterText);
            userText = Console.ReadLine();

            Console.Write(MsgUserElection);
            userElection = Console.ReadLine().ToLower();

            Console.WriteLine();

            if (userElection.Equals("mayus") || userElection.Equals("minus"))
            {
                Console.WriteLine($"{MsgConvertedText} {TextConverter(userText, userElection)}");
            }
            else
            {
                Console.WriteLine(MsgWrongElection);
            }
        }

        static public string TextConverter(string userText, string userElection)
        {
            return userElection.Equals("mayus") ? userText.ToUpper() : userText.ToLower();
        }
    }
}