using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class Queen : ChessPiece
    {
        public Queen(string xy) :
            base(PieceType.Queen, new MoveStyle(7, MoveDirection.Any), xy)
        {
        
        }
    }
}
