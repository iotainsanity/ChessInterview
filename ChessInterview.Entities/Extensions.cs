using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities
{
    public static class Extensions
    {
        public static int ToX(this char column)
        {
            switch (column)
            {
                case 'a':
                    return 1;
                case 'b':
                    return 2;
                case 'c':
                    return 3;
                case 'd':
                    return 4;
                case 'e':
                    return 5;
                case 'f':
                    return 6;
                case 'g':
                    return 7;
                case 'h':
                    return 8;
                default:
                    return -1;
            }
        }
    }
}
