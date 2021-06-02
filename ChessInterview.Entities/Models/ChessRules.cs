using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public static class ChessRules
    {
        public static List<char> ValidX = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        public static List<int> ValidY = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
    }
}
