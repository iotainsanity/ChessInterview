using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public static class ChessRules
    {
        public static List<string> ValidColumn = new List<string> { "a","b","c","d","e","f","g","h" };
        public static List<int> ValidY = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
        public static List<int> ValidX = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

    }
}
