using System;

namespace SortingAlgorithms
{
    public static  class Printer
    {
       public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0}   ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("==================================");
        }

    }
}
