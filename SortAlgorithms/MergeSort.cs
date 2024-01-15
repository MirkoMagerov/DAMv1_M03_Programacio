using System;

namespace Program
{
    public class Class
    {
        public static void Main()
        {
            Console.Write("Cantidad de números: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < array.Length; i++)
            {
                int actualNum;
                do
                {
                    Console.Write($"Escribe los números (Número actual: {i + 1}): ");
                    actualNum = Convert.ToInt32(Console.ReadLine());

                } while (actualNum % 1 != 0);
                array[i] = actualNum;
            }

            array = MergeSort(array, 0, array.Length - 1);

            foreach (int number in array)
            {
                Console.WriteLine(number);
            }
        }

        public static int[] MergeSort(int[] array, int start, int final)
        {
            if (start < final)
            {
                int medium = (start + final) / 2;

                MergeSort(array, start, medium);
                MergeSort(array, (medium + 1), final);

                Merge(array, start, medium, final);
            }

            return array;
        }

        public static int[] Merge(int[] array, int start, int medium, int final)
        {
            int n1 = medium - start + 1;
            int n2 = final - medium;

            int[] left = new int[n1];
            int[] right = new int[n2];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[start + i];
            }

            for (int j = 0; j < right.Length; j++)
            {
                right[j] = array[medium + 1 + j];
            }

            int leftIndex = 0, rightIndex = 0, arrayIndex = start;

            while (leftIndex < n1 && rightIndex < n2)
            {
                if (left[leftIndex] <= right[rightIndex])
                {
                    array[arrayIndex] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    array[arrayIndex] = right[rightIndex];
                    rightIndex++;
                }
                arrayIndex++;
            }

            while (leftIndex < n1)
            {
                array[arrayIndex] = left[leftIndex];
                leftIndex++;
                arrayIndex++;
            }

            while (rightIndex < n2)
            {
                array[arrayIndex] = right[rightIndex];
                rightIndex++;
                arrayIndex++;
            }

            return array;
        }
    }
}