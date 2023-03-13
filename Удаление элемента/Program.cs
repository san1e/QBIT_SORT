using System;

namespace Удаление_элемента
{
    internal class Program
    {
        static string Delete(int[] arr,int index)
        {
            int[] newArray = new int[arr.Length - 1];
            Array.Copy(arr, 0, newArray, 0, index);
            Array.Copy(arr, index + 1, newArray, index, arr.Length - index - 1);
            arr = newArray;
            string str = string.Join(" ", arr);
            return str;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(Delete(arr,index-1));
        }
    }
}
