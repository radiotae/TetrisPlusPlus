using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{
    class TPiece : AbstractTetrisPiece
    {
        public TPiece() : base()
        {
            StartBlockCoord = new Point[4]
            {
                new Point(3,4),
                new Point(4,3),
                new Point(4,4),
                new Point(5,4)
            };

            CurrBlockCoord = StartBlockCoord;

            Color = PieceColor.Purple;
        }
    }
}
