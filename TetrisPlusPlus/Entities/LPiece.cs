using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{
    class LPiece : AbstractTetrisPiece
    {
        public LPiece() : base()
        {
            BlockCoord = new Point[4]
            {
                new Point(3,4),
                new Point(4,4),
                new Point(5,3),
                new Point(5,4)
            };

            Color = PieceColor.Orange;
        }
    }
}
