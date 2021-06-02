using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public abstract class ChessPiece
    {
        public ChessPiece(PieceType pieceType,MoveStyle moveStyle,string xy)
        {
            PieceType = pieceType;
            MoveStyle = moveStyle;
            BoardSquare = new BoardSquare(xy);
        }

        public BoardSquare BoardSquare { get; set; }
        public MoveStyle MoveStyle { get; set; }
        public PieceType PieceType { get; set; }

        public virtual List<BoardSquare> GetValidMoves()
        {
            return new MoveEngine().GetMoves(this);
        }
    }
}
