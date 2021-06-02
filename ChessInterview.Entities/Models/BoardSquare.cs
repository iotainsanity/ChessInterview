using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class BoardSquare
    {
        public char Column;
        public int X;
        public int Y;

        public BoardSquare(char column, int y)
        {
            Column = column;
            X = column.ToX();
            Y = y;
        }

        public BoardSquare(string xy)
        {
            Column = xy.First();
            X = Column.ToX();
            Y = xy.Last();
        }
    }
}
