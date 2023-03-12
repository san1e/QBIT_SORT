using System;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Следующий_после_минимального
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int min = arr.Min();
            int next = int.MaxValue;
            int index = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > min && arr[i] < next)
                {
                    next = arr[i];
                    index = i+1;
                }
            }
            Console.WriteLine($"{next} {index}");
        }
    }
}
