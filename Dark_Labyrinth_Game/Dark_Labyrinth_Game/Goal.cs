using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Dark_Labyrinth_Game
{
    public class Goal : Field
    {
        public bool drawn { get; set; }
        public Goal(int X, int Y)
            : base(X, Y)
        {
            drawn = false;
        }

        public override void draw(Graphics g, int panelWidth, int mazeSize)
        {
            // drawing a flag
            SolidBrush brush = new SolidBrush(Color.White);
            int rectSide = panelWidth / mazeSize;
            int startPointWidth = rectSide * coordX; // counting x blocks from left
            int startPointHeight = panelWidth - (rectSide * (coordY + 1)); // counting y + 1 blocks from bottom
            g.FillRectangle(brush, startPointWidth, startPointHeight, rectSide, rectSide);

            brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, startPointWidth + rectSide / 6, startPointHeight + (rectSide * 5) / 6, rectSide / 2, rectSide / 12);
            g.FillRectangle(brush, startPointWidth + (int)(rectSide * 3.5) / 12 + rectSide / 12, startPointHeight + rectSide / 6, rectSide / 12, (rectSide * 2) / 3);
            Point [] triPoints = new Point[3];
            triPoints[0] = new Point(startPointWidth + (int)(rectSide * 3.5) / 12 + rectSide / 12, startPointHeight + rectSide / 6);
            triPoints[1] = new Point(startPointWidth + (rectSide * 2) / 3 + rectSide / 6, startPointHeight + rectSide / 3);
            triPoints[2] = new Point(startPointWidth + (int)(rectSide * 3.5) / 12 + rectSide / 12, startPointHeight + rectSide / 2);
            brush = new SolidBrush(Color.ForestGreen);
            g.FillPolygon(brush, triPoints);
        }

        public override void shadow(Graphics g, int panelWidth, int mazeSize)
        {
            //the finish is always visible
            draw(g, panelWidth, mazeSize);
        }
    }
}
