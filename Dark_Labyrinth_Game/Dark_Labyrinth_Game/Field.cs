using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dark_Labyrinth_Game
{
    public abstract class Field
    {
        public int coordX { get;  set; }
        public int coordY { get;  set; }

        public Field(int X, int Y)
        {
            coordX = X;
            coordY = Y;
        }

        public abstract void draw(Graphics g, int panelWidth, int mazeSize);
        public virtual void shadow(Graphics g, int panelWidth, int mazeSize)
        {
            SolidBrush brush = new SolidBrush(Color.Black);
            int rectSide = panelWidth / mazeSize;
            int startPointWidth = rectSide * coordX; // counting x blocks from left
            int startPointHeight = panelWidth - (rectSide * (coordY + 1)); // counting y + 1 blocks from bottom
            g.FillRectangle(brush, startPointWidth, startPointHeight, rectSide, rectSide);
            brush.Dispose();
        }
    }
}
