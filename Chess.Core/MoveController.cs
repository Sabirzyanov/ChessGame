using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Core
{
    public abstract class MoveController
    {
        public abstract void Move(Piece piece, string position);
    }
}
