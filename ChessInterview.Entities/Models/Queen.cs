using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class Queen : ChessPiece
    {
        public Queen()
        {
            PieceType = PieceType.Queen;
            MoveStyle = new MoveStyle(7, MoveDirection.Any);
        }
    }
}
