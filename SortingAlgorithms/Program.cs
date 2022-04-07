using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            // Gelen Sıralamaların görselleştirilmesi -> https://miro.medium.com/max/1400/1*UyFDoJcmOEtljnII2tJaLg.gif
            // Görselleştirmek için -> https://www.toptal.com/developers/sorting-algorithms
            // Tek tek incelemek için -> https://sadanandpai.github.io/sorting-visualizer/dist/
            // Tek tek incelemek için -> https://visualgo.net/en/sorting
            //int[] array = RandomArray.Generate(10, 10); /*{ 33, 11, 44, 22 }*/;

            do
            {
                int[] array = { 6, 5, 3, 1, 8, 7, 2, 4 };


                //Merge sıralamasını kavramak için açılıp debug edilmelidir. Bu dizi kullanılmalıdır -> int[] array = { 44,  11, 33, 22 };
                //int[] dizi = Merge.SortV2(array);  

                Console.Clear();
                Console.WriteLine("-> Bubble Sorting: 1 \n-> Selection Sorting: 2 \n-> Insertion Sorting: 3 \n-> Merge Sorting: 4 \n-> Heap Sorting: 5");
                Console.Write("Sıralama Seçiniz:");
                int selectedSort = int.TryParse( Console.ReadLine(),out selectedSort)?selectedSort:0;

                Console.WriteLine("Dizinin Sıralanmamış Hali");
                Printer.Print(array);

                switch (selectedSort)
                {
                    case 1: Bubble.Sort(array); break;
                    case 2: Selection.Sort(array); break;
                    case 3: Insertion.Sort(array); break;
                    case 4: Merge.Sort(array, 0, array.Length - 1); break;
                    case 5: Heap.SortV2(array); break;
                    default: Bubble.Sort(array); break;
                }

                Console.WriteLine("Dizinin Sıralı Hali");
                Printer.Print(array);

            } while (Console.ReadKey().Key == ConsoleKey.R);
        }


    }
}


