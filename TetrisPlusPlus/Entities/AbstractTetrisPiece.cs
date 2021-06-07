using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{

    abstract class AbstractTetrisPiece
    {
        public Point[] BlockCoord;
        public CurrentRotation CurrRotation;

        public PieceColor Color { get; protected set; }


        public List<Point[]> Rotations { get; protected set; }

        public AbstractTetrisPiece()
        {
            CurrRotation = CurrentRotation.Base;
        }
    }
}
