using System;

namespace lec13_ex5
{
    class Program
    {
        private static void CountingSort(int[] arr)
        {
            int max = arr.Max();
            int min = arr.Min();

            int[] count = new int[max - min + 1];
            int z = 0;

            for (int i = 0; i < count.Length; i++)
            {
                count[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }

            for (int i = min; i <= max; i++)
            {
                while (count[i - min]-- > 0)
                {
                    arr[z] = i;
                    z++;
                }
            }

            foreach (var x in arr)
            {
                Console.Write(x + " ");
            }
        }
    }
}