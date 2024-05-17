using System;
using System.Runtime.InteropServices;

namespace Part4___2048
{
    class Program
    {
        public static void PrintArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] +" ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Board board = new Board();
            board.InitializationTwoCells();
            PrintArr(board.Data);
        }
    }
}
