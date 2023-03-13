using System;
using System.Threading;

namespace Сортировка_пузырьком
{
    internal class Program
    {
        static int Bubble(int[] arr)
        {
            int count = 0;
            int temp;
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                        count++;
                    }
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(Bubble(arr));
        }
    }
}
