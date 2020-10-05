using System;

namespace ArrayAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[,] rotation = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 16, 17 } };
            foreach (var item in rotation)
            {
                Console.WriteLine(item);
            }
        }
    }
}
