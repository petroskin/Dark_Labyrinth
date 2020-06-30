using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dark_Labyrinth_Game
{
    public partial class LevelForm : Form
    {
        public Level level { get; set; }
        public ChooseLevelForm parent;
        public Graphics g { get; set; }

        public LevelForm(ChooseLevelForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            toolStripStatusLabel1.Text = "Use the arrow keys to move!";
            switch (parent.chooseLevel)
            {
                case 1:
                    level = Levels.level1();
                    Text = "Level 1";
                    break;
                case 2:
                    level = Levels.level2();
                    Text = "Level 2";
                    break;
                case 3:
                    level = Levels.level3();
                    Text = "Level 3";
                    break;
                case 4:
                    level = Levels.level4();
                    Text = "Level 4";
                    break;
                case 5:
                    level = Levels.level5();
                    Text = "Level 5";
                    break;
                case 6:
                    level = Levels.level6();
                    Text = "Level 6";
                    break;
                case 7:
                    level = Levels.level7();
                    Text = "Level 7";
                    break;
            }
        }

        private void closeForm()
        {
            parent.Visible = true;
            this.Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            level.restart();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.closeForm();
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = DrawingPanel.CreateGraphics();
            g.Clear(Color.White);
            level.setGraphics(g, DrawingPanel.Size.Width);
            this.g = g;
        }

        private void LevelForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 38)
            {
                if (!level.move(Level.MoveDirection.Up))
                    return;
            }
            if (e.KeyValue == 40)
            {
                if (!level.move(Level.MoveDirection.Down))
                    return;
            }
            if (e.KeyValue == 37)
            {
                if (!level.move(Level.MoveDirection.Left))
                    return;
            }
            if (e.KeyValue == 39)
            {
                if (!level.move(Level.MoveDirection.Right))
                    return;
            }
            if (e.KeyValue == 32)
            {
                if (!level.teleport())
                    return;
            }

            if (level.fields[level.player.coordX, level.player.coordY] is Portal)
                toolStripStatusLabel1.Text = "Press SPACE to use portal!";
            else
                toolStripStatusLabel1.Text = "";

            if (level.gameOver)
            {
                if (parent.chooseLevel == 7)
                    MessageBox.Show("Congratulations! You completed the game!");
                else if (!parent.progress.progress[parent.chooseLevel])
                {
                    MessageBox.Show("Well done! New level unlocked.");
                    parent.addLevel();
                }
                else
                {
                    MessageBox.Show("Well done!");
                }
                this.closeForm();
            }
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Level.showHelp();
        }
    }
}
