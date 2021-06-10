using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{
    class LinePiece : AbstractTetrisPiece
    {
        public LinePiece() : base()
        {
            StartBlockCoord = new Point[4]
            {
                new Point(3,4),
                new Point(4,4),
                new Point(5,4),
                new Point(6,4)
            };

            CurrBlockCoord = StartBlockCoord;

            Color = PieceColor.LightBlue;
        }
    }
}
