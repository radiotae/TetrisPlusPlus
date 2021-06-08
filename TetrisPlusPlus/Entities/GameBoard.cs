using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TetrisPlusPlus.Entities
{

    class GameBoard
    {
        public const byte GRID_WIDTH = 10;
        public const byte GRID_HEIGHT = 24;
        public const byte TOTAL_PIECES = 7;

        private AbstractBlock[,] _grid;
        List<AbstractTetrisPiece> _pieceList;

        private AbstractTetrisPiece _holdPiece;

        private Random _random;

        public GameBoard(Point loc)
        {
            _random = new Random();
            



        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {

        }

        private void ResetBoard()
        {
            _grid = new AbstractBlock[GRID_WIDTH, GRID_HEIGHT];

            for (int x=0; x<GRID_WIDTH; x++)
            {
                for (int y=0; y<GRID_HEIGHT; y++)
                {
                    _grid[x, y] = new EmptyBlock();
                }
            }


        }

        private List<AbstractTetrisPiece> MakeNewBag()
        {
            List<AbstractTetrisPiece> newBag = new List<AbstractTetrisPiece>();

            newBag.Add(new JPiece());

            

            byte p = TOTAL_PIECES;
            while (p > 1)
            {
                p--;
                int y = _random.Next(0, p + 1);
                TetrisPieces temp = newBag[y];
                newBag[y] = newBag[p];
                newBag[p] = temp;
            }

            return newBag;
        }
    }
}
