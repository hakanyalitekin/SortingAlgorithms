using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal static class RandomArray
    {
        internal static int[] Generate(int arrLength, int arrMax)
        {

            Random rnd = new Random();
            int[] test = new int[rnd.Next(arrLength)];
            for (int i = 0; i < test.Length; i++)
            {
                test[i] = rnd.Next(arrMax);
                Console.WriteLine(test[i]);
            }
            return test;
        }
    }
}
