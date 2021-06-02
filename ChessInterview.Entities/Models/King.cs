using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class King : ChessPiece
    {
        public King()
        {
            PieceType = PieceType.King;
            MoveStyle = new MoveStyle(1, MoveDirection.Any);
        }
    }
}
