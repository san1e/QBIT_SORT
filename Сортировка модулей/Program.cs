using System;

namespace Сортировка_модулей
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (Math.Abs(arr[i]) > Math.Abs(arr[j]) || (Math.Abs(arr[i]) == Math.Abs(arr[j]) && arr[i] > arr[j]))
                    {
                        int temp = arr[i];
                        arr[i] =arr[j];
                        arr[j] = temp;
                    }
                }
            }
            string str = string.Join(" ", arr);
            Console.WriteLine(str);

        }
    }
}
