using System;

namespace SortingAlgorithms
{
    public static class Insertion
    {
       public static void Sort(int[] array)
        {
            // Dans ile anlatımı. ->   https://www.youtube.com/watch?v=ROalU379l3U
            Console.WriteLine("Insertion(Araya Ekleme) Sort");

            for (int i = 1; i < array.Length; i++)
            {
                int currentValue = array[i];
                int previousIndex = i - 1;

                while (previousIndex >= 0 && currentValue < array[previousIndex])
                {
                    array[previousIndex + 1] = array[previousIndex];
                    previousIndex = previousIndex - 1;
                }
                array[previousIndex + 1] = currentValue;

                Printer.Print(array);
            }
        }

    }
}
