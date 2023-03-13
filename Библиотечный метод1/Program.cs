using System;
using System.Linq;

namespace Библиотечный_метод1
{
    internal class Program
    {
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                if (j >= 0 && arr[j] > key)
                {
                    while (j >= 0 && arr[j] > key)
                    {

                        arr[j + 1] = arr[j];
                        j = j - 1;
                    }
                    arr[j + 1] = key;
                    string str = string.Join(" ", arr);
                    Console.WriteLine(str);
                }
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);
            Array.Sort(copy);
            if (copy.SequenceEqual(arr))
            {
                Console.WriteLine("The array is already sorted");
            }
            else
            {
                SelectionSort(arr);
            }
        }
    }
}
