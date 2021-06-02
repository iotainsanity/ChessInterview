using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public abstract class ChessPiece
    {
        public BoardSquare Board { get; set; }
        public MoveStyle MoveStyle { get; set; }
        public PieceType PieceType { get; set; }

        public virtual void GetValidMoves()
        { 
            
        }
    }
}
