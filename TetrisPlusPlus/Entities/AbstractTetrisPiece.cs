using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{

    abstract class AbstractTetrisPiece : ITetrisPiece
    {
        
        public CurrentRotation CurrRotation { get; set; }
        public Point[] CurrBlockCoord { get; set; }

        public Point[] StartBlockCoord { get; protected set; }
        public PieceColor Color { get; protected set; }
        public List<Point[]> Rotations { get; protected set; }
        

        public AbstractTetrisPiece()
        {
            CurrRotation = CurrentRotation.Base;

        }

        
    }
}
