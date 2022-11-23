using System;

namespace ConsoleApp14
{
    class Program
    {
        static void PrintHello()
        {
            Console.WriteLine("Hello, world");
        }
        static void PrintMassive(int [,] massive)
        {
            int rows = massive.GetUpperBound(0) + 1;
            int columns = massive.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine($"element[{i},{j}] = {massive[i,j]}");
                }
            }
        }


        static void GenerateRandomElement(int[,] massive)
        {
            Random rnd = new Random();
            int rows = massive.GetUpperBound(0) + 1;
            int columns = massive.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    massive[i, j] = rnd.Next(10);
                }
            }
        }

        static void Main(string[] args)
        {
            int[,] numbers2 = new int [5,7];
            GenerateRandomElement(numbers2);
            PrintMassive(numbers2);
        }
    }
}
