using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dark_Labyrinth_Game
{
    public class Path : Field
    {
        public Path(int X, int Y) : base(X, Y) { }

        public override void draw(Graphics g, int panelWidth, int mazeSize)
        {
            SolidBrush brush = new SolidBrush(Color.White);
            int rectSide = panelWidth / mazeSize;
            int startPointWidth = rectSide * coordX; // counting x blocks from left
            int startPointHeight = panelWidth - (rectSide * (coordY + 1)); // counting y + 1 blocks from bottom
            g.FillRectangle(brush, startPointWidth, startPointHeight, rectSide, rectSide);
            brush.Dispose();
        }
    }
}
