using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class King : ChessPiece
    {
        public King(string xy) :
            base(PieceType.King, new MoveStyle(1, MoveDirection.Any), xy)
        { 
        
        }   
    }
}

