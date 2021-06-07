using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{
    class Block : AbstractBlock
    {
        public PieceColor Color;

        public Block()
        {
            IsEmpty = false;
        }
    }
}
