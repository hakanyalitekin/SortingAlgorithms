using System;

namespace SortingAlgorithms
{
    public class Merge
    {
        public static void Sort(int[] array, int left, int right)
        {
            //Console.WriteLine("Merge (Birleştirme) Sort");

            //Recursive yani kendi kendini çağıran bir metot.

            int leftEnd; //Bu aslında ikiye bölünmüş listenin, birinci parçasının yani sol listenin son indeksini temsil ediyor.
            if (left < right)
            {
                leftEnd = (left + right) / 2;

                //Sol listeyi sürekli 2'ye bölüyoruz.
                Sort(array, left, leftEnd);

                //Sağ listeyi sürekli 2'ye bölüyoruz.
                Sort(array, (leftEnd + 1), right);

                DoMerge(array, left, (leftEnd + 1), right);

            }
            Printer.Print(array);

        }
        public static void DoMerge(int[] array, int left, int rightStart, int right)
        {
            int[] temp = new int[array.Length];
            int leftEnd, numElements, tempLeft;

            tempLeft = left;
            leftEnd = rightStart - 1;
            numElements = right - left + 1;

            while ((left <= leftEnd) && (rightStart <= right))
            {
                if (array[left] <= array[rightStart])
                {
                    temp[tempLeft++] = array[left++];
                }
                else
                {
                    temp[tempLeft++] = array[rightStart++];
                }
            }
            while (left <= leftEnd)
            {
                temp[tempLeft++] = array[left++];
            }

            while (rightStart <= right)
            {
                temp[tempLeft++] = array[rightStart++];
            }

            for (int i = 0; i < numElements; i++)
            {
                array[right] = temp[right];
                right--;
            }

        }


        #region Kavramak için Farklı Bir Versiyon
        public static int[] SortV2(int[] dizi)
        {
            if (dizi.Length <= 1)
                return dizi; //1 eleman zaten kıyaslanacak bir şey yok yukarı yolluyoruz.

            int i, k = 0;
            int ortaIndex = dizi.Length / 2; //ikiye bölüyoruz. Bölümden kalan aşağı yuvarlandığı için elde ettiğimiz bu ortaIndex ile dizi sol sağ diye ayırabiliyoruz.

            int[] solDizi = new int[ortaIndex]; //sol kısıma ilk yarısını
            int[] sagDizi = new int[dizi.Length - ortaIndex]; //sağ kısma diğer yarısını atıyoruz

            for (i = 0; i < ortaIndex; i++)
                solDizi[i] = dizi[i]; // sol diziyi dolduruyoruz

            for (i = ortaIndex; i < dizi.Length; i++)
            {
                sagDizi[k] = dizi[i]; //sağ diziyi dolduruyoruz
                k++;
            }

            solDizi = SortV2(solDizi); //kalan diziyi tekrar yolluyoruz ikiye bölünsün diye
            sagDizi = SortV2(sagDizi); //kalan diziyi tekrar yolluyoruz ikiye bölünsün diye

            Printer.Print(dizi);
            return Birlestir(solDizi, sagDizi); // daha sonra birleştire gidiyoruz.
        }

        static int[] Birlestir(int[] sol, int[] sag)
        {
            int[] siralananDizi = new int[sol.Length + sag.Length]; // a dizisi oluşturduk.

            int i = 0, j = 0, k = 0;


            while (j < sol.Length && i < sag.Length)
                if (sag[i] < sol[j]) //Şu küçüktür işaretini büyüktür yaparsak tersten sıralanır. :)
                {
                    siralananDizi[k++] = sag[i++];
                }
                else
                {
                    siralananDizi[k++] = sol[j++];
                }
            //siralananDizi[k++] = (sag[i] > sol[j]) ? sag[i++] : sol[j++]; yukarının tek satır hali.

            while (i < sag.Length)
                siralananDizi[k++] = sag[i++]; //sağ kısım dönene kadar a dizisine sağı at

            while (j < sol.Length) //sol kısım tamamen bitene kadar a dizisine at
                siralananDizi[k++] = sol[j++];

            return siralananDizi; // en son a dizisini gönder diyoruz..
        }
        #endregion
    }
}
