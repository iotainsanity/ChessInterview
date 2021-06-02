using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities
{
    public static class Extensions
    {
        public static int ToX(this string column)
        {
            switch (column)
            {
                case "a":
                    return 1;
                case "b":
                    return 2;
                case "c":
                    return 3;
                case "d":
                    return 4;
                case "e":
                    return 5;
                case "f":
                    return 6;
                case "g":
                    return 7;
                case "h":
                    return 8;
                default:
                    return -1;
            }
        }

        public static string ToColumn(this int X)
        {
            switch (X)
            {
                case 1:
                    return "a";
                case 2:
                    return "b";
                case 3:
                    return "c";
                case 4:
                    return "d";
                case 5:
                    return "e";
                case 6:
                    return "f";
                case 7:
                    return "g";
                case 8:
                    return "h";
                default:
                  return "";
            }
        }
    }
}
