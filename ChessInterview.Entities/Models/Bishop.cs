using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class Bishop : ChessPiece
    {
        public Bishop() 
        {
            this.PieceType = PieceType.Bishop;
            MoveStyle = new MoveStyle(7, MoveDirection.Diagonal);
        }
    }
}
