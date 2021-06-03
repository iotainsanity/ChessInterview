using ChessInterview.Entities.Models;
using System;

namespace ChessInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine(GetInput());
                Console.WriteLine();
            }
        }

        private static string GetInput()
        {
            Console.Write("Please select your piece." + Environment.NewLine + "1. King" + Environment.NewLine + "2. Queen" + Environment.NewLine + "3. Rook" + Environment.NewLine + "4. Bishop");
            Console.WriteLine();
            var piece = Console.ReadLine();

            Console.WriteLine("Please enter the starting position.");
            var startingPosition = Console.ReadLine();

            ChessPiece chessPiece;

            switch (piece)
            {
                case "1":
                    chessPiece = new King(startingPosition);
                    break;
                case "2":
                    chessPiece = new Queen(startingPosition);
                    break;
                case "3":
                    chessPiece = new Rook(startingPosition);
                    break;
                case "4":
                    chessPiece = new Bishop(startingPosition);
                    break;
                default:
                    return "Invalid selection. Please try again.";
            }

            string validMoves = "";

            foreach (var item in chessPiece.GetValidMoves())
            {
                validMoves += item.SquareName + ",";
            }

            return "Valid Moves are: " + validMoves.Remove(validMoves.Length - 1);
        }
    }
}
