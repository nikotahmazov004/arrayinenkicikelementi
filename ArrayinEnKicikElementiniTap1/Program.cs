using System;

namespace ArrayinEnKicikElementiniTap1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 16, 27, 4, 35 };
            int min = 16;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
