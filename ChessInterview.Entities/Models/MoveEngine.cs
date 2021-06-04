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
            List<BoardSquare> validMoves = new List<BoardSquare>();

            int spacesMoved = 1;
            while (ChessRules.ValidY.Contains(chessPiece.BoardSquare.Y + spacesMoved) && ChessRules.ValidX.Contains(chessPiece.BoardSquare.X + spacesMoved) 
                && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.X + spacesMoved, chessPiece.BoardSquare.Y + spacesMoved));
                spacesMoved++;
            }

            spacesMoved = 1;
            while (ChessRules.ValidY.Contains(chessPiece.BoardSquare.Y + spacesMoved) && ChessRules.ValidX.Contains(chessPiece.BoardSquare.X - spacesMoved)
                && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.X - spacesMoved, chessPiece.BoardSquare.Y + spacesMoved));
                spacesMoved++;
            }

            spacesMoved = 1;
            while (ChessRules.ValidY.Contains(chessPiece.BoardSquare.Y - spacesMoved) && ChessRules.ValidX.Contains(chessPiece.BoardSquare.X + spacesMoved)
                && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.X + spacesMoved, chessPiece.BoardSquare.Y - spacesMoved));
                spacesMoved++;
            }

            spacesMoved = 1;
            while (ChessRules.ValidY.Contains(chessPiece.BoardSquare.Y - spacesMoved) && ChessRules.ValidX.Contains(chessPiece.BoardSquare.X - spacesMoved)
                && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.X - spacesMoved, chessPiece.BoardSquare.Y - spacesMoved));
                spacesMoved++;
            }

            return validMoves;
        }

        public List<BoardSquare> GetXYMoves(ChessPiece chessPiece)
        {
            List<BoardSquare> validMoves = new List<BoardSquare>();
            
            int spacesMoved = 1;
            while (ChessRules.ValidY.Contains(chessPiece.BoardSquare.Y + spacesMoved) && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.Column, chessPiece.BoardSquare.Y + spacesMoved));
                spacesMoved++;
            }

            spacesMoved = 1;
            while (ChessRules.ValidY.Contains(chessPiece.BoardSquare.Y - spacesMoved) && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.Column, chessPiece.BoardSquare.Y - spacesMoved));
                spacesMoved++;
            }

            spacesMoved = 1;
            while (ChessRules.ValidX.Contains(chessPiece.BoardSquare.X + spacesMoved) && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.X + spacesMoved, chessPiece.BoardSquare.Y));
                spacesMoved++;
            }

            spacesMoved = 1;
            while (ChessRules.ValidX.Contains(chessPiece.BoardSquare.X - spacesMoved) && spacesMoved <= chessPiece.MoveStyle.MaxSpaces)
            {
                validMoves.Add(new BoardSquare(chessPiece.BoardSquare.X - spacesMoved, chessPiece.BoardSquare.Y));
                spacesMoved++;
            }

            return validMoves;
        }

        public string GetMovesAsCSV(ChessPiece chessPiece)
        {
            string validMoves = "";

            foreach (var item in chessPiece.GetValidMoves())
            {
                validMoves += item.SquareName + ",";
            }

            return validMoves.Remove(validMoves.Length - 1);
        }
    }
}
