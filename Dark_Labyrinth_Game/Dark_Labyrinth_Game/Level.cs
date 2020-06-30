using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Dark_Labyrinth_Game
{
    public class Level
    {
        public Field [,] fields { get;  set; }
        public Path start { get;  set; }
        public Player player { get;  set; }
        public List<Field> visibleFields { get;  set; }
        public bool gameOver { get;  set; }
        public Graphics graphics { get;  set; }
        public int panelWidth { get; set; }
        public MoveDirection lastMove;
        public enum MoveDirection
        {
            Up,
            Down,
            Left,
            Right,
            Undefined
        }

        public Level(Field [,] gameFields, Player gamePlayer)
        {
            fields = gameFields;
            player = gamePlayer;
            graphics = null;
            lastMove = MoveDirection.Undefined;
            start = new Path(player.coordX, player.coordY);
        }

        public static void showHelp()
        {
            string tips = "Use the arrow keys to move." + "\n\n" +
                "Press SPACE when on a portal to use it." + "\n\n" +
                "Find your way to the green flag to win!";
            MessageBox.Show(tips, "How to play");
        }

        public bool move(MoveDirection direction)
        {
            if (direction == MoveDirection.Left || direction == MoveDirection.Right)
                lastMove = direction;
            if (!player.move(direction))
                return false;
            if (fields[player.coordX,player.coordY] is Goal)
            {
                gameOver = true;
                revealAll();
            }
            else
                updateVisibleFields();
            return true;
        }

        public bool teleport()
        {
            if (!(fields[player.coordX,player.coordY] is Portal))
                return false;
            Portal portal = (Portal)fields[player.coordX,player.coordY];
            if (!player.teleport(portal.destinationX, portal.destinationY))
                return false;
            updateVisibleFields();
            return true;
        }

        public void updateVisibleFields()
        {
            // Get rid of the far fields first
            for (int i = 0; i < visibleFields.Count; i++)
            {
                Field field = visibleFields.ElementAt(i);
                if (Math.Abs(field.coordX - player.coordX) > 1 || Math.Abs(field.coordY - player.coordY) > 1)
                {
                    visibleFields.Remove(field);
                    i--;
                    field.shadow(graphics, panelWidth, fields.GetLength(0));
                }
            }
            // Get new near fields
            Field[] nearbyFields = { 
                                       fields[player.coordX + 1,player.coordY + 1],
                                       fields[player.coordX + 1,player.coordY],
                                       fields[player.coordX + 1,player.coordY - 1],
                                       fields[player.coordX,player.coordY + 1],
                                       fields[player.coordX,player.coordY],
                                       fields[player.coordX,player.coordY - 1],
                                       fields[player.coordX - 1,player.coordY + 1],
                                       fields[player.coordX - 1,player.coordY],
                                       fields[player.coordX - 1,player.coordY - 1],
                                   };
            // Update near fields
            for (int i = 0; i < nearbyFields.Length; i++)
            {
                if (!visibleFields.Contains(nearbyFields[i]))
                    visibleFields.Add(nearbyFields[i]);
                nearbyFields[i].draw(graphics, panelWidth, fields.GetLength(0));
            }
            drawPlayer(graphics, panelWidth, lastMove);
        }

        public void revealAll()
        {
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    fields[i,j].draw(graphics, panelWidth, fields.GetLength(0));
                }
            }
        }

        public void restart()
        {
            player.teleport(start.coordX, start.coordY);
            setGraphics(graphics, panelWidth);
        }

        public void setGraphics(Graphics g, int panelWidth)
        {
            graphics = g;
            this.panelWidth = panelWidth;
            for (int i = 0; i < fields.GetLength(0); i++)
            {
                for (int j = 0; j < fields.GetLength(1); j++)
                {
                    fields[i, j].shadow(graphics, panelWidth, fields.GetLength(0));
                }
            }
            visibleFields = new List<Field>();
            updateVisibleFields();
        }

        public void drawPlayer(Graphics g, int panelWidth, MoveDirection prevMove)
        {
            int rectSide = panelWidth / fields.GetLength(0);
            int startPointWidth = rectSide * player.coordX; // counting x blocks from left
            int startPointHeight = panelWidth - (rectSide * (player.coordY + 1)); // counting y + 1 blocks from bottom
            if (prevMove == MoveDirection.Left)
                g.DrawImage(Properties.Resources.PlayerLeft, startPointWidth, startPointHeight, rectSide, rectSide);
            else if (prevMove == MoveDirection.Right || prevMove == MoveDirection.Undefined)
                g.DrawImage(Properties.Resources.PlayerRight, startPointWidth, startPointHeight, rectSide, rectSide);
        }
    }
}
