using System;

namespace TachDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap chieu dai day: ");
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(" ");
            int[] arr = new int[n];
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i] != "")
                {
                    arr[j] = int.Parse(str[i]);
                    j++;
                }
            }

            foreach (var a in arr)
            {
                if (a % 2 == 0)
                    Console.Write(a + " ");
            }
            Console.WriteLine();
            foreach (var a in arr)
            {
                if (a % 2 != 0)
                    Console.Write(a + " ");
            }
        }
    }
}
