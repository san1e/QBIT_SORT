using System;

namespace Объединение_последовательностей
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());

            int i = 1;
            int j = 1;
            int c = 1;

            while (c <= k)
            {
                if (Math.Pow(i,2) < Math.Pow(j,3))
                {
                    c++;
                    i++;
                }
                else if (Math.Pow(i,2) >Math.Pow(j,3))
                {
                    c++;
                    j++;
                }
                else
                { 
                    c++;
                    i++;
                    j++;
                }
            }

            Console.WriteLine((i - 1) * (i - 1));
        }
    }
}
