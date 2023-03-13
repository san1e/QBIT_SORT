using System;
using System.Linq;

namespace Второй_по_величине_элемент
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int max = arr.Max();
            int next = int.MinValue;
            int index = -1;
            int MaxIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < max && arr[i] >= next)
                {
                    next = arr[i];
                    index = i + 1;
                }
                if (arr[i] == next && i > MaxIndex)
                {
                   
                    MaxIndex = i;
                }
            }
            Console.WriteLine($"{next} {index}");
        }
    }
}
