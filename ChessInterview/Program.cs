using ChessInterview.Entities.Models;
using System;

namespace ChessInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new Rook();
            x.GetValidMoves();

            Console.WriteLine("Hello World!");
        }
    }
}
