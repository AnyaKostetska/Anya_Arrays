using Anya_Arrays;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string [] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }
            Console.WriteLine(Arrays.GetReverseOfArray(array));

            //Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"{i} {Arrays.GetMinOfArray(array)}");
            //}
        }
    }
}