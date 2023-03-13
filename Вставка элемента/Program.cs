using System;

namespace Вставка_элемента
{
    internal class Program
    {
        static string Insert(int[] arr, int index, int value)
        {
            Array.Resize(ref arr, arr.Length + 1); 
            Array.Copy(arr, index, arr, index + 1, arr.Length - index - 1); 
            arr[index] = value;
            string str = string.Join(" ", arr);
            return str;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] ins = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Console.WriteLine(Insert(arr, ins[0]-1, ins[1]));
        }
    }
}
