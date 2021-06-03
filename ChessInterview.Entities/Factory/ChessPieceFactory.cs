using ChessInterview.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Factory
{
    public static class ChessPieceFactory
    {
        public static ChessPiece GetChessPiece(PieceType pieceType, string xy)
        {
            switch (pieceType)
            {
                case PieceType.King:
                    return new King(xy);
                case PieceType.Queen:
                    return new Queen(xy);
                case PieceType.Bishop:
                    return new Bishop(xy);
                case PieceType.Rook:
                    return new Rook(xy);
                default:
                    return null;
            }
        }
    }
}
