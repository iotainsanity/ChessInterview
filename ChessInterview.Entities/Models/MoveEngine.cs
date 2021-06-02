using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class MoveEngine
    {
        public List<BoardSquare> GetMoves(ChessPiece chessPiece)
        {
            var validMoves = new List<BoardSquare>();

            switch (chessPiece.MoveStyle.MoveDirection)
            {
                case MoveDirection.Diagonal:
                    validMoves.AddRange(GetDiagonalMoves(chessPiece));
                    break;
                case MoveDirection.XY:
                    validMoves.AddRange(GetXYMoves(chessPiece));
                    break;
                case MoveDirection.Any:
                    validMoves.AddRange(GetDiagonalMoves(chessPiece));
                    validMoves.AddRange(GetXYMoves(chessPiece));
                    break;
                default:
                    break;
            }

            return validMoves;
        }

        public List<BoardSquare> GetDiagonalMoves(ChessPiece chessPiece)
        {
            return new List<BoardSquare>();
        }

        public List<BoardSquare> GetXYMoves(ChessPiece chessPiece)
        {
            return new List<BoardSquare>();
        }
    }
}
