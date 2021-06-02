using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class Rook : ChessPiece
    {
        public Rook(string xy) :
            base(PieceType.Rook, new MoveStyle(7, MoveDirection.XY), xy)
        {
        
        }
    }
}
