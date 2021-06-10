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
        List<ITetrisPiece> _pieceList;

        private ITetrisPiece _holdPiece;

        private Random _random;

        public GameBoard(Point loc)
        {
            _random = new Random();

            ResetBoard();


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

            _holdPiece = null;

            _pieceList = new List<ITetrisPiece>();

            _pieceList.AddRange(MakeNewBag());
            _pieceList.AddRange(MakeNewBag());
        }

        private List<ITetrisPiece> MakeNewBag()
        {
            List<ITetrisPiece> newBag = new List<ITetrisPiece>();

            newBag.Add(new JPiece());
            newBag.Add(new OPiece());
            newBag.Add(new ZPiece());
            newBag.Add(new SPiece());
            newBag.Add(new LinePiece());
            newBag.Add(new TPiece());
            newBag.Add(new LPiece());

            

            byte p = TOTAL_PIECES;
            while (p > 1)
            {
                p--;
                int y = _random.Next(0, p + 1);
                ITetrisPiece temp = newBag[y];
                newBag[y] = newBag[p];
                newBag[p] = temp;
            }

            return newBag;
        }

        public void SwapHoldPiece()
        {
            _pieceList[0].CurrBlockCoord = _pieceList[0].StartBlockCoord;

            if (_holdPiece == null)
            {
                

                _holdPiece = _pieceList[0];

                _pieceList.Remove(_pieceList[0]);
            }
            else
            {
                ITetrisPiece piece = _holdPiece;
                _holdPiece = _pieceList[0];
                _pieceList[0] = piece;
            }

        }
    }
}
