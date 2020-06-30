using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dark_Labyrinth_Game
{
    public class InvalidPositionException : System.Exception
    {
        public InvalidPositionException() : base() { }
        public InvalidPositionException(string message) : base(message) { }
    }

    public class Player
    {
        public Field [,] fields { get; set; }
        public int coordX { get; set; }
        public int coordY { get; set; }

        public Player(Field[,] gameFields, int X, int Y)
        {
            if (gameFields[X,Y] is Wall)
                throw new InvalidPositionException();
            fields = gameFields;
            coordX = X;
            coordY = Y;
        }

        public bool move(Level.MoveDirection direction)
        {
            if (direction == Level.MoveDirection.Up)
                return moveUp();
            if (direction == Level.MoveDirection.Down)
                return moveDown();
            if (direction == Level.MoveDirection.Left)
                return moveLeft();
            if (direction == Level.MoveDirection.Right)
                return moveRight();
            return false;
        }

        private bool moveUp()
        {
            if (fields[coordX,coordY + 1] is Wall)
                return false;
            coordY++;
            return true;
        }

        private bool moveDown()
        {
            if (fields[coordX,coordY - 1] is Wall)
                return false;
            coordY--;
            return true;
        }

        private bool moveLeft()
        {
            if (fields[coordX - 1,coordY] is Wall)
                return false;
            coordX--;
            return true;
        }

        private bool moveRight()
        {
            if (fields[coordX + 1,coordY] is Wall)
                return false;
            coordX++;
            return true;
        }

        public bool teleport(int X, int Y)
        {
            if (fields[X,Y] is Wall)
                return false;
            coordX = X;
            coordY = Y;
            return true;
        }
    }
}
