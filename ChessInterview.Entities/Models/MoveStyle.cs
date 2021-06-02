using System;
using System.Collections.Generic;
using System.Text;

namespace ChessInterview.Entities.Models
{
    public class MoveStyle
    {
        public int MaxSpaces;
        public MoveDirection MoveDirection;

        public MoveStyle(int maxSpaces, MoveDirection moveDirection)
        {
            MaxSpaces = maxSpaces;
            MoveDirection = moveDirection;
        }
    }
}
