using System;

namespace Сортировка
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);
            string str = string.Join(" ", arr);
            Console.WriteLine(str);
        }
    }
}

