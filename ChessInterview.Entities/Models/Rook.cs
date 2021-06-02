using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class Rook : ChessPiece
    {
        public Rook()
        {
            PieceType = PieceType.Rook;
            MoveStyle = new MoveStyle(7,MoveDirection.XY);
        }
    }
}
