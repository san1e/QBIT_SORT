using System;

namespace Сортировка___чётные_и_нечётные
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            for (int i = 0; i < n; i++)
            {
                int temp;
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
