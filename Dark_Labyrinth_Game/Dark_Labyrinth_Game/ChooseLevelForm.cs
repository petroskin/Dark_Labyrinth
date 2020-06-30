using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Dark_Labyrinth_Game
{
    public partial class ChooseLevelForm : Form
    {
        public int chooseLevel { get;  set; }
        public Progress progress { get; set; }
        public string fileName { get; set; }
        public ChooseLevelForm()
        {
            InitializeComponent();
            fileName = null;
            progress = new Progress();
            updateProgress();
            panel1.BackgroundImage = Properties.Resources.background;
        }

        private void saveProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Dark Labyrinth save file (*.dala)|*.dala";
                saveFileDialog.Title = "Save progress in file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    fileName = saveFileDialog.FileName;
            }
            else
            {
                if (MessageBox.Show("Saving may overwrite previous data. Proceed?",
                "Save progress",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }
            if (fileName != null)
            {
                System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                System.IO.FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, progress);
                stream.Close();
            }
        }

        private void loadProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Dark Labyrinth save file (*.dala)|*.dala";
            openFileDialog.Title = "Load progress from file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fileName = openFileDialog.FileName;
                    System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    System.IO.FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
                    progress = (Progress)formatter.Deserialize(stream);
                    stream.Close();
                    updateProgress();
                    string [] name = fileName.Split('\\');
                    Text = name[name.Length - 1].Split('.')[0];
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error: Could not read file \"" + fileName + "\" from disk. Original error: " + exception.Message);
                    fileName = null;
                }
            }
        }

        private void deleteProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all progress? Previously unlocked levels will be locked.",
                "Delete progress",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show("Progress successfully deleted!");
                progress = new Progress();
                updateProgress();
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            LevelForm levelForm = new LevelForm(this);
            levelForm.Show();
        }

        public void addLevel()
        {
            progress.progress[cbChooseLevel.Items.Count] = true;
            updateProgress();
        }

        private void cbChooseLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseLevel = cbChooseLevel.SelectedIndex + 1;
        }

        private void saveProgressAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileName = null;
            saveProgressToolStripMenuItem_Click(this, e);
        }

        private void updateProgress()
        {
            cbChooseLevel.Items.Clear();
            for (int i = 0; i < 7; i++)
            {
                if (!progress.progress[i])
                {
                    cbChooseLevel.SelectedIndex = i - 1;
                    cbChooseLevel_SelectedIndexChanged(this, null);
                    break;
                }
                cbChooseLevel.Items.Add("Level " + (i + 1));
                // support for last level
                if (i == 6)
                    cbChooseLevel.SelectedIndex = i;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Level.showHelp();
        }
    }
}
