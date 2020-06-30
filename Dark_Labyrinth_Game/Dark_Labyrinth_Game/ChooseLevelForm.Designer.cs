namespace Dark_Labyrinth_Game
{
    partial class ChooseLevelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProgressAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteProgressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbChooseLevel = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose level:";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStartGame.Location = new System.Drawing.Point(167, 122);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(113, 56);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = "START GAME";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveProgressToolStripMenuItem,
            this.saveProgressAsToolStripMenuItem,
            this.loadProgressToolStripMenuItem,
            this.deleteProgressToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveProgressToolStripMenuItem
            // 
            this.saveProgressToolStripMenuItem.Name = "saveProgressToolStripMenuItem";
            this.saveProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveProgressToolStripMenuItem.Text = "Save progress";
            this.saveProgressToolStripMenuItem.Click += new System.EventHandler(this.saveProgressToolStripMenuItem_Click);
            // 
            // saveProgressAsToolStripMenuItem
            // 
            this.saveProgressAsToolStripMenuItem.Name = "saveProgressAsToolStripMenuItem";
            this.saveProgressAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveProgressAsToolStripMenuItem.Text = "Save progress as...";
            this.saveProgressAsToolStripMenuItem.Click += new System.EventHandler(this.saveProgressAsToolStripMenuItem_Click);
            // 
            // loadProgressToolStripMenuItem
            // 
            this.loadProgressToolStripMenuItem.Name = "loadProgressToolStripMenuItem";
            this.loadProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadProgressToolStripMenuItem.Text = "Load progress";
            this.loadProgressToolStripMenuItem.Click += new System.EventHandler(this.loadProgressToolStripMenuItem_Click);
            // 
            // deleteProgressToolStripMenuItem
            // 
            this.deleteProgressToolStripMenuItem.Name = "deleteProgressToolStripMenuItem";
            this.deleteProgressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteProgressToolStripMenuItem.Text = "Delete progress";
            this.deleteProgressToolStripMenuItem.Click += new System.EventHandler(this.deleteProgressToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.howToPlayToolStripMenuItem.Text = "How to play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // cbChooseLevel
            // 
            this.cbChooseLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbChooseLevel.FormattingEnabled = true;
            this.cbChooseLevel.Location = new System.Drawing.Point(12, 150);
            this.cbChooseLevel.Name = "cbChooseLevel";
            this.cbChooseLevel.Size = new System.Drawing.Size(121, 28);
            this.cbChooseLevel.TabIndex = 5;
            this.cbChooseLevel.SelectedIndexChanged += new System.EventHandler(this.cbChooseLevel_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbChooseLevel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 190);
            this.panel1.TabIndex = 6;
            // 
            // ChooseLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 214);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChooseLevelForm";
            this.Text = "Dark Labyrinth";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadProgressToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProgressToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbChooseLevel;
        private System.Windows.Forms.ToolStripMenuItem saveProgressAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}