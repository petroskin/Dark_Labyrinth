using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dark_Labyrinth_Game
{
    public class Wall : Field
    {
        public Wall(int X, int Y) : base(X, Y) { }

        public override void draw(Graphics g, int panelWidth, int mazeSize)
        {
            SolidBrush brush = new SolidBrush(Color.DarkGray);
            int rectSide = panelWidth / mazeSize;
            int startPointWidth = rectSide * coordX; // counting x blocks from left
            int startPointHeight = panelWidth - (rectSide * (coordY + 1)); // counting y + 1 blocks from bottom
            g.FillRectangle(brush, startPointWidth, startPointHeight, rectSide, rectSide);
            brush.Dispose();

            brush = new SolidBrush(Color.LightGray);
            startPointWidth += rectSide / 6;
            startPointHeight += rectSide / 6;
            rectSide = (rectSide * 2) / 3;
            g.FillRectangle(brush, startPointWidth, startPointHeight, rectSide, rectSide);
            brush.Dispose();
        }
    }
}
