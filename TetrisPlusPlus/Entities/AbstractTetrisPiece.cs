using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{

    abstract class AbstractTetrisPiece : ITetrisPiece
    {
        
        public CurrentRotation CurrRotation { get; set; }

        public Point[] BlockCoord { get; set; }
        public PieceColor Color { get; protected set; }
        public List<Point[]> Rotations { get; protected set; }


        public AbstractTetrisPiece()
        {
            CurrRotation = CurrentRotation.Base;

        }

        
    }
}
