using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dark_Labyrinth_Game
{
    public class Portal : Path
    {
        public int destinationX { get;  set; }
        public int destinationY { get;  set; }

        public Portal(int X, int Y, int dX, int dY)
            : base(X, Y)
        {
            destinationX = dX;
            destinationY = dY;
        }

        public override void draw(Graphics g, int panelWidth, int mazeSize)
        {
            // drawing a portal
            base.draw(g, panelWidth, mazeSize);
            SolidBrush brush = new SolidBrush(Color.LightSkyBlue);
            int rectSide = panelWidth / mazeSize;
            int startPointWidth = rectSide * coordX; // counting x blocks from left
            int startPointHeight = panelWidth - (rectSide * (coordY + 1)); // counting y + 1 blocks from bottom
            startPointWidth += rectSide / 6;
            int newRectSide = (rectSide * 2) / 3;
            g.FillEllipse(brush, startPointWidth, startPointHeight, newRectSide, newRectSide);

            brush = new SolidBrush(Color.LightGray);
            startPointHeight += (rectSide * 9) / 12;
            startPointWidth -= rectSide / 8;
            g.FillRectangle(brush, startPointWidth, startPointHeight, newRectSide + (rectSide / 4), rectSide / 4);
            brush.Dispose();
        }
    }
}
