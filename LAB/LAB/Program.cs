using System;

namespace LAB
{
    class Program
    {
        static void Main(string[] args)
        {
            //task3
            int[] arr = { 1, 2, 3, 4, 8, 16, 17, 18, 21, 30 };

            foreach (int i in arr)
            {
                if (i % 3 == 0 || i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Task4

            int[] arr2 = { 1, 2, 5, 7, 8, 10, 12, 15, 18, 19 };

            for (int i = 0; i < arr2.Length; i++)
            {
                if (i % 2 == 0)
                {
                    arr2[i] = 0;

                }

            }

            foreach (int item in arr2)
            {
                Console.WriteLine(item);
            }

        }
    }
}

