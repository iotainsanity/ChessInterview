using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public static class ChessBoard
    {
        private static List<BoardSquare> _boardSquares;

        public static List<BoardSquare> BoardSquares
        {
            get 
            {
                if (_boardSquares == null)
                    InitializeBoard();

                return _boardSquares;
            }
        }

        private static void InitializeBoard()
        {
            _boardSquares = new List<BoardSquare>();

            foreach (var x in ChessRules.ValidColumn)
            {
                foreach (var y in ChessRules.ValidY)
                {
                    _boardSquares.Add(new BoardSquare(x, y));
                }
            }
        }
    }
}