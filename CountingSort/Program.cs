using System;


namespace CountingSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            CountingSort cs = new CountingSort();
            Random randNum = new Random();
            var watch = new System.Diagnostics.Stopwatch();
            
            //int[] array = { 2, 3, 4, 1, 1, 4, 5 };
            int[] array = new int[1000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(0, 1000);
            }

            Console.WriteLine("Distribution Counting Sort");

            watch.Start();
            int[] sortedArray1 = cs.DistributionCountingSort(array);

            for (int i = 0; i < sortedArray1.Length; i++)
            {
                Console.Write(sortedArray1[i] + " ");
            }
            watch.Stop();
            Console.WriteLine($"\n\nExecution Time of Distribution Sort: {watch.ElapsedMilliseconds} ms\n\n\n");


            Console.WriteLine("Comparision Counting Sort");

            watch.Start();
            int[] sortedArray2 = cs.ComparisionCountingSort(array);

            for (int i = 0; i < sortedArray2.Length; i++)
            {
                Console.Write(sortedArray2[i] + " ");
            }
            watch.Stop();
            Console.WriteLine($"\n\nExecution Time of Comparision Sort: {watch.ElapsedMilliseconds} ms\n\n\n");
        }

    }
}
