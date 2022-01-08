namespace SortingAlgorithms
{
    public static class Heap
    {
        public static void Sort(int[] array)
        {
            // Heap in ilk oluşturulma bolumu
            // (array.Length / 2) - 1 -> diziyi sağ sol olmak üzere iki ayırıyoruz. -1 diyerekte root'a koyduğumuzu düşüyoruz. 
            for (int i = (array.Length / 2) - 1; i >= 0; i--)
                Heapify(array, array.Length, i);//Heapify'a gönderilecek kısım


            // Tek tek ayırma işlemi 
            for (int i = array.Length - 1; i >= 0; i--)
            {
                //Kökün sonuna kadar devam edecek 
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // indirgenmiş öbek de maximum elamanı çağır
                Heapify(array, i, 0);
            }
        }

        private static void Heapify(int[] array, int arrayLength, int root)
        {
            int biggest = root; // En büyük kök olarak ata
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            // Eğer sol çocuk kökten büyükse
            if (left < arrayLength && array[left] > array[biggest])
                biggest = left;

            // Sağ çocuk şu ana kadar ki en büyük çocuksa
            if (right < arrayLength && array[right] > array[biggest])
                biggest = right;

            // Kökten daha büyük değer yoksa
            if (biggest != root)
            {
                int swap = array[root];
                array[root] = array[biggest];
                array[biggest] = swap;

                // Etkilenen alt ağaçları tekrar özyineleme uygulama işlemi
                Heapify(array, arrayLength, biggest);
                Printer.Print(array);
            }
        }



        #region Kavramak için Farklı Bir Versiyon
        public static void SortV2(int[] dizi)
        {
            for (int sayac = ((dizi.Length / 2) - 1); sayac >= 0; sayac--)
                HeapifyV2(sayac, dizi.Length, dizi);

            for (int i = dizi.Length - 1; i >= 1; i--)
            {
                int gecici = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = gecici;
                HeapifyV2(0, i - 1, dizi);
            }
        }

        private static void HeapifyV2(int root, int arrayLength, int[] array)
        {
            bool IsFinish = false;
            int node, temp;

            while ((root * 2 <= arrayLength) && (!IsFinish))
            {
                if (root * 2 == arrayLength)
                    node = root * 2;

                else if (array[root * 2] > array[root * 2 + 1])
                    node = root * 2;

                else
                    node = root * 2 + 1;

                if (node < array.Length && array[root] < array[node])
                {
                    temp = array[root];
                    array[root] = array[node];
                    array[node] = temp;
                    root = node;
                }
                else
                {
                    IsFinish = true;
                }
            }
        }

        #endregion
    }
}
