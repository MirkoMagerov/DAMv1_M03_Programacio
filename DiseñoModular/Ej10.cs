/*
* Author: Miroslav Magerov
* M03. Programaci� UF2
* v1. dd/mm/aa
* Exercici 10.
*/

namespace Proyecto
{
    public static class ConsoleApp
    {
        // C�DIGO MAIN
        static void Main(string[] args)
        {
            const string MsgToFindNumber = "Introduce un n�mero para saber si se encuentra en la lista: ";
            const string MsgFoundNumber = "El n�mero se encuentra entre la lista de n�meros aleatorios.";
            const string MsgNotFoundNumber = "El n�mero no se encuentra entre la lista de n�meros aleatorios.";
            const int RandomNumbersArrayLength = 10, MinNumber = 0, MaxNumber = 201;

            // PARAMETRO PARA ORDENAR LA ARRAY DE MANERA ASCENDENTE (TRUE) O DESCENDENTE (FALSE).
            bool orderArray = true;

            float userNumber;
            Random random = new Random();

            int[] randomNumbersArray = new int[RandomNumbersArrayLength];

            Console.Write(MsgToFindNumber);
            userNumber = Convert.ToSingle(Console.ReadLine());

            for (int i = 0; i < randomNumbersArray.Length; i++)
            {
                randomNumbersArray[i] = random.Next(MinNumber, MaxNumber);
            }

            OrderArray(orderArray, ref randomNumbersArray);

            Console.WriteLine(SearchNum(randomNumbersArray, userNumber) ? MsgFoundNumber : MsgNotFoundNumber);
        }

        public static void OrderArray(bool order, ref int[] array)
        {
            if (order)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j])
                        {
                            int aux = array[i];
                            array[i] = array[j];
                            array[j] = aux;
                        }
                    }
                }
            }

            else
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] < array[j])
                        {
                            int aux = array[i];
                            array[i] = array[j];
                            array[j] = aux;
                        }
                    }
                }
            }
        }

        public static bool SearchNum(int[] array, float number)
        {
            bool foundNumber = false;
            int j = 0;

            do
            {
                if (array[j] == number)
                {
                    foundNumber = true;
                }
                else
                {
                    j++;
                }

            } while (j < array.Length && !foundNumber);

            return foundNumber;
        }
    }
}