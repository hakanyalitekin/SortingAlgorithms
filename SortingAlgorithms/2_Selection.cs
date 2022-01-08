using System;

namespace SortingAlgorithms
{
    public class Selection
    {
        public static void Sort(int[] array)
        {
            // Dans ile anlatımı. -> https://www.youtube.com/watch?v=Ns4TPTC8whw
            Console.WriteLine("Selection(Seçim) Sort");

            // (array.Length-1) diyoruz zaten son elemana gelmeden önce sıralama tamamlanmış oluyor.
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
                Printer.Print(array);
            }
        }

    }
}
