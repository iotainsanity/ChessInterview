using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class Bishop : ChessPiece
    {
        public Bishop(string xy) :
            base(PieceType.Bishop,new MoveStyle(7,MoveDirection.Diagonal),xy)
        {
        }
    }
}
