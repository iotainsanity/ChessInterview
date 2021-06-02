using ChessInterview.Entities.Models;
using System;

namespace ChessInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Queen("a1");
            foreach (var item in x.GetValidMoves())
            {
                Console.WriteLine(item.SquareName);
            } 

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
