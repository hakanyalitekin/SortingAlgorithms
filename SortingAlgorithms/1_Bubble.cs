using System;

namespace SortingAlgorithms
{
    public static class Bubble
    {
        public static void Sort(int[] array)
        {
            // Dans İle Anlatım - > https://www.youtube.com/watch?v=lyZQPjUT5B4
            Console.WriteLine("Bubble(Kabarcık-Baloncuk) Sort");

            // (array.Length - 1) diyoruz çünkü zaten bir önceki ile kıyaslamış oluyoruz ve kendinden sonra bir eleman yok.
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int j = 1; j <= array.Length - 1; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                    }
                }
                Printer.Print(array);
            }
        }

    }
}
