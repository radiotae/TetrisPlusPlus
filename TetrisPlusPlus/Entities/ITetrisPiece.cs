using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{
    interface ITetrisPiece
    {
        public Point[] StartBlockCoord { get; }

        public Point[] CurrBlockCoord { get; set; }
        public CurrentRotation CurrRotation { get; set; }

        public PieceColor Color { get; }


        public List<Point[]> Rotations { get; }
    }
}
