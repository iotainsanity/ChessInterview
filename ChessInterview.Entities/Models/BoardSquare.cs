using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class BoardSquare
    {
        public string Column;
        public int X;
        public int Y;

        public string SquareName { get { return Column + Y; } }

        public BoardSquare(string column, int y)
        {
            Column = column;
            X = column.ToX();
            Y = y;
        }

        public BoardSquare(string xy)
        {
            Column = xy.Substring(0,1);
            X = Column.ToX();
            Y = Convert.ToInt32(xy.Substring(1,1));
        }

        public BoardSquare(int x, int y)
        {
            X = x;
            Y = y;
            Column = x.ToColumn();
        }
    }
}
