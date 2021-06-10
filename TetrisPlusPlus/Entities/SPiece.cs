using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{
    class SPiece : AbstractTetrisPiece
    {
        public SPiece() : base()
        {
            StartBlockCoord = new Point[4]
            {
                new Point(3,4),
                new Point(4,3),
                new Point(4,4),
                new Point(5,3)
            };

            CurrBlockCoord = StartBlockCoord;

            Color = PieceColor.Green;
        }
    }
}
